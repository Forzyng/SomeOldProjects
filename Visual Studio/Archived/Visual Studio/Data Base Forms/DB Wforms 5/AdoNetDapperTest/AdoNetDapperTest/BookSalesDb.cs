using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDapperTest
{
    using Dapper;
    public class BookSalesDb
    {
        private string connectionString;
        private IDbConnection connection;
        public BookSalesDb(string connectionString)
        {
            this.connectionString = connectionString;
            connection = null;
        }
        public ICollection<Countrie> Countries
        {
            get
            {
                using(connection=new SqlConnection(connectionString))
                {
                    string sql = "select * from Countries";
                    return connection.Query<Countrie>(sql).ToList();
                }
            }
        }

        public ICollection<Author> Authors
        {
            get
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string sql = "select * from Authors a join Countries c on a.CountriesID = c.Id";
                    //return connection.Query<Author, Countrie, Author>(sql, 
                    //    (author, countrie)=> {
                    //        author.Countrie = countrie;
                    //        return author;
                    //    })
                    //    .ToList();

                    var authors = connection.Query<Author, Countrie, Author>(sql,
                        (author, countrie) =>
                        {
                            author.Countrie = countrie;
                            return author;
                        });
                    return authors.ToList();
                }
            }
        }
        public int AddCountrie(Countrie countrie)
        {
            using(connection = new SqlConnection(connectionString))
            {
                string sql = "insert into Countries(Name, Continent) values(@Name, @Continent)";
                return connection.Execute(sql,countrie);
            }
        }

    }
}
