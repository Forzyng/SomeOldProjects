using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace Date_Base_Exam_New
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Connection_SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\SQL inquiries\Exam\SQL FIiles by Danil\Date_Base_Exam_New\Date_Base_Exam_New\Book_Magazine.mdf;Integrated Security=True");
            Connection_SQL.Open();

            //Read_Authors(Connection_SQL);
            //Read_Book_Count(Connection_SQL, "c5f771fb-a645-4ba1-8155-f3f5002b2b89");
            //Read_Themes_And_Books(Connection_SQL);
            //AddThemes(Connection_SQL);
            TestStoredProc(Connection_SQL);


            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
            Connection_SQL.Close();
            
        }

        static void Read_Authors(SqlConnection Connection_SQL)
        {
            #region Command And Read
            //SqlCommand CommandNew = new SqlCommand("SELECT * FROM Authors");
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT * FROM Authors";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();
            var first = true;

            while (Reader.Read())
            {
                if (first)
                {
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        Console.Write(Reader.GetName(i) + "\t");
                    }

                }

                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " \t");
                }
                Console.WriteLine();
                first = false;
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
            #endregion
        }

        static void Read_Book_Count(SqlConnection Connection_SQL, string id)
        {
            SqlParameter Paramentr_New = new SqlParameter("id", System.Data.SqlDbType.NVarChar);
            Paramentr_New.Value = id;
            SqlCommand Command_New = new SqlCommand("SELECT COUNT(Id) FROM Books WHERE AuthorsId = @id");
            Command_New.Parameters.Add(Paramentr_New);
            Command_New.Connection = Connection_SQL;
            
            Console.WriteLine("\n\n Books count => " + Command_New.ExecuteScalar().ToString());
        }

        static void Read_Themes_And_Books(SqlConnection Connection_SQL)
        {
            SqlCommand Command_New = new SqlCommand();
            Command_New.CommandText = "SELECT [Name] FROM [Themes];" + 
                "SELECT [Name], [Pages], [Price] FROM [Books] ORDER BY [Name];" + 
                "SELECT [Name] + ' ' + [Surname] AS Author FROM Authors ORDER BY 1;";
            Command_New.Connection = Connection_SQL;

            SqlDataReader Reader = Command_New.ExecuteReader();
            bool first = true;
            do
            {
                first = true;
                while (Reader.Read())
                {
                    if (first)
                    {
                        for (int i = 0; i < Reader.FieldCount; i++)
                        {
                            Console.Write(Reader.GetName(i) + "\t");
                        }

                    }

                    Console.WriteLine();
                    //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        Console.Write(Reader[i] + " \t");
                    }
                    Console.WriteLine();
                    first = false;
                }
                Console.WriteLine();
                Console.WriteLine();
            } while (Reader.NextResult());
                Reader.Close();
            
        }

        static void AddThemes(SqlConnection Connection_SQL)
        {
            Console.Clear();
            Console.Write("Enter new theme: ");
            string theme = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(theme))
            {
                return;
            }

            SqlCommand Command_New = new SqlCommand("INSERT INTO [Themes] ([Name]) VALUES (@theme)", Connection_SQL);
            Command_New.Parameters.Add("@theme", System.Data.SqlDbType.NVarChar).Value = theme;
            try
            {
            int count = Command_New.ExecuteNonQuery();
            Console.WriteLine($"\nОбработано строк: {count}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nOoops... Smth went wrong: {ex.Message}");
            }

        }

        //static void Test_Stored_Proc(SqlConnection Connection_SQL)
        //{
            
        //    string name, surname, country_name;
        //    Console.Write("Enter Name: ");
        //    name = Console.ReadLine();
        //    Console.Write("Enter Surname: ");
        //    surname = Console.ReadLine();
        //    Console.Write("Enter country name: ");
        //    country_name = Console.ReadLine();
        //    if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(country_name))
        //    {
        //        return;
        //    }
        //    SqlCommand Command_New = new SqlCommand("sp_Add_Author", Connection_SQL);

        //    Command_New.CommandType = System.Data.CommandType.StoredProcedure;

        //    Command_New.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, name.Length).Value = name;
        //    Command_New.Parameters.Add("@surname", System.Data.SqlDbType.NVarChar, surname.Length).Value = surname;
        //    Command_New.Parameters.Add("@country_name", System.Data.SqlDbType.NVarChar, country_name.Length).Value = country_name;

        //    SqlParameter id = Command_New.Parameters.Add("@id", System.Data.SqlDbType.NVarChar);
        //    id.Direction = System.Data.ParameterDirection.Output;

        //    Command_New.ExecuteNonQuery();
        //    Console.WriteLine("\n\nAuthors Id = {0}", id.Value.ToString());
        //}



        static void TestStoredProc(SqlConnection Connection_SQL)
        {
            string name, surname, country_name;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter country name: ");
            country_name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(country_name))
            {
                return;
            }


            SqlCommand Command_New = new SqlCommand("sp_Add_Author", Connection_SQL);

            Command_New.CommandType = System.Data.CommandType.StoredProcedure;



            Command_New.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, name.Length).Value = name;
            Command_New.Parameters.Add("@surname", System.Data.SqlDbType.NVarChar, surname.Length).Value = surname;
            Command_New.Parameters.Add("@country_name", System.Data.SqlDbType.NVarChar, country_name.Length).Value = country_name;



            SqlParameter id = Command_New.Parameters.Add("@id", System.Data.SqlDbType.NVarChar, 36);
            id.Direction = System.Data.ParameterDirection.Output;



            Command_New.ExecuteNonQuery();
            Console.WriteLine("\n\nAuthors Id = {0}\n", id.Value.ToString());
        }


    }
}
