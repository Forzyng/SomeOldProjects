using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace DB_Console_PR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Connection_SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\DataBase\DB Console PR 2\DB Console PR 2\DB.mdf;Integrated Security=True");
            string input;
            bool check = true;
            try
            {
                Connection_SQL.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\t\tOooops... Smth went wrong");
                Console.WriteLine(ex.Message);
                Console.ReadKey(true);
                return;
            }  
            
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\tSuccess");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);


            //
            //
            //
            //
            //
            //
            //

            //
            //
            //
            //

            #region Menu



            do
            {


                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\tChoose any option =>");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tFrom First Task =>");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1) Read all Products from DB <=");

                Console.WriteLine("2) Read all Types from DB <=");

                Console.WriteLine("3) Read all Supplier from DB <=");

                Console.WriteLine("4) Read maximum quantity from DB <=");

                Console.WriteLine("5) Read minimal quantity  from DB <=");

                Console.WriteLine("6) Read minimal price from DB <=");

                Console.WriteLine("7) Read maximum price from DB <=");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tFrom Second Task =>");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkBlue;




                Console.WriteLine("8) Read exactly products by id type from DB <=");

                Console.WriteLine("9) Read exactly products by supplier from DB <=");

                Console.WriteLine("10) Read oldest product from DB <=");

                Console.WriteLine("11) Read average quantity in all type from DB <=");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("12) Exit");
                Console.WriteLine();




                Console.WriteLine("\n\nPress any key... ");

                do
                {
                    input = Console.ReadLine();
                } while (Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 12);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                switch (input)
                {
                    case "1":
                        Read_All_FROM_Product(Connection_SQL);
                        break;
                    case "2":
                        Read_All_FROM_Type(Connection_SQL);
                        break;
                    case "3":
                        Read_All_FROM_Supplier(Connection_SQL);
                        break;
                    case "4":
                        Read_Max_Quantity(Connection_SQL);
                        break;
                    case "5":
                        Read_Min_Quantity(Connection_SQL);
                        break;
                    case "6":
                        Read_Min_Price(Connection_SQL); 
                        break;
                    case "7":
                        Read_Max_Price(Connection_SQL);
                        break;
                    case "8":
                        Console.Write("Enter Id: ");
                        string IdType = Console.ReadLine();
                        Read_Product_Exac_Type(Connection_SQL, IdType);
                        break;
                    case "9":
                        Console.Write("Enter Supplier: ");
                        string SupplierName = Console.ReadLine();
                        Read_Product_Exac_Supplier(Connection_SQL, SupplierName);
                        break;
                    case "10":
                        Read_Oldest_Product(Connection_SQL);
                        break;
                    case "11":
                        Read_AVG_Quantity_IN_Type(Connection_SQL);
                        break;
                    case "12":
                        check = false;
                        break;

                }


            } while (check);




            Connection_SQL.Close();


            #endregion
        }

        #region Task 3

        static void Read_All_FROM_Product(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT * FROM Product";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t | ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);


            
            
        }

        static void Read_All_FROM_Type(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT * FROM Type_Product";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t | ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_All_FROM_Supplier(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT * FROM Supplier";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t | ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_Max_Quantity(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MAX(P.Name), MAX(S.Quantity)  FROM Storage S JOIN Product P ON S.Id_of_product = P.Id";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_Min_Quantity(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MIN(P.Name), MIN(S.Quantity)  FROM Storage S JOIN Product P ON S.Id_of_product = P.Id";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_Min_Price(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MIN(P.Name), MIN(S.Price)  FROM Storage S JOIN Product P ON S.Id_of_product = P.Id";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_Max_Price(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MAX(P.Name), MAX(S.Price)  FROM Storage S JOIN Product P ON S.Id_of_product = P.Id";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        #endregion

        #region Task 4

        static void Read_Product_Exac_Type(SqlConnection Connection_SQL, string Type_P)
        {
            SqlParameter Paramentr_New = new SqlParameter("@Type_P", System.Data.SqlDbType.NVarChar);
            Paramentr_New.Value = Type_P;
            SqlCommand Command_New = new SqlCommand("SELECT P.Name FROM Product P JOIN Type_Product T ON P.Type_Id = T.Id WHERE T.Id LIKE @Type_P");
            Command_New.Parameters.Add(Paramentr_New);
            Command_New.Connection = Connection_SQL;


            SqlDataReader Reader = Command_New.ExecuteReader();



            while (Reader.Read())
            {
                Console.WriteLine();
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }

                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);

        }

        static void Read_Product_Exac_Supplier(SqlConnection Connection_SQL, string Supp_name)
        {
            SqlParameter Paramentr_New = new SqlParameter("@Supp_name", System.Data.SqlDbType.NVarChar);
            Paramentr_New.Value = Supp_name;
            SqlCommand Command_New = new SqlCommand("SELECT P.Name FROM Product P JOIN Storage St ON P.Id = St.Id_of_product JOIN Supplier S ON St.Supplier_Id = S.Id WHERE S.Name = @Supp_name GROUP BY P.Name");
            Command_New.Parameters.Add(Paramentr_New);
            Command_New.Connection = Connection_SQL;


            SqlDataReader Reader = Command_New.ExecuteReader();



            while (Reader.Read())
            {
                Console.WriteLine();
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }

                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_Oldest_Product(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MIN(P.Name), MIN(S.Date_incoming) FROM Storage S JOIN Product P ON S.Id_of_product = P.Id ";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();

                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    Console.Write(Reader[i] + " |\t ");
                }
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }

        static void Read_AVG_Quantity_IN_Type(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT T.Name AS [Type], AVG(St.Quantity) AS [Average Quantity] FROM Product P JOIN Storage St ON P.Id = St.Id_of_product JOIN Type_Product T ON P.Type_Id = T.Id WHERE T.Name IN ( SELECT Name FROM Type_Product GROUP BY Name ) GROUP BY T.Name ORDER BY [Average Quantity] DESC";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();
            var first = true;

            while (Reader.Read())
            {
                if (first)
                {
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        Console.Write(Reader.GetName(i) + "\t\t");
                    }

                }

                Console.WriteLine();
                Console.WriteLine();

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
        }

        #endregion
    }
}
