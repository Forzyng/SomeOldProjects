using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace DB_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Connection_SQL = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\DataBase\DB Console\DB Console\DataB.mdf;Integrated Security=True");
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
            #region Menu

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\tSuccess");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);


            do
            {


                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\tChoose any option =>");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tFrom First Task =>");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("1) Read all from DB <=");

                Console.WriteLine("2) Read all FIO from DB <=");

                Console.WriteLine("3) Read all average marks from DB <=");

                Console.WriteLine("4) Read all average marks that Less than a certain number from DB <=");

                Console.WriteLine("5) Read all subjects where students have minimal mark from DB <=");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tFrom Second Task =>");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("6) Read minimal average mark from DB <=");

                Console.WriteLine("7) Read maximum average mark from DB <=");

                Console.WriteLine("8) Show count of people with minimal mark on certain subject from DB <=");

                Console.WriteLine("9) Show count of people with maximum mark on certain subject from DB <=");

                Console.WriteLine("10) Show count all students in all groups from DB <=");

                Console.WriteLine("11) Show average mark in groups from DB <=");

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
                        Read_All(Connection_SQL);
                        break;
                    case "2":
                        Read_FIO(Connection_SQL);
                        break;
                    case "3":
                        Read_AVG_Marks(Connection_SQL);
                        break;
                    case "4":
                        Console.Write("Enter mark: ");
                        do
                        {
                            input = Console.ReadLine();
                        } while (Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 12);
                        Check_Avg_Exactly(Connection_SQL, Convert.ToInt32(input));
                        break;
                    case "5":
                        Read_All_MIN_SUBJ(Connection_SQL);
                        break;


                    case "6":
                        Read_Min(Connection_SQL);
                        break;
                    case "7":
                        Read_Max(Connection_SQL);
                        break;
                    case "8":
                        Console.Write("Enter subject: ");
                        string subjMin = Console.ReadLine();
                        Read_Exac_MIN(Connection_SQL, subjMin);
                        break;
                    case "9":
                        Console.Write("Enter subject: ");
                        string subjMax = Console.ReadLine();
                        Read_Exac_MAX(Connection_SQL, subjMax);
                        break;
                    case "10":
                        Read_Count_In_All_Groups(Connection_SQL);
                        break;
                    case "11":
                        Read_AVG_Group(Connection_SQL);
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
        // 1
        static void Read_All(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT * FROM Marks";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

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
        // 2
        static void Read_FIO(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT [Surname], [Name], [SecName]  FROM Marks";
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
        // 3
        static void Read_AVG_Marks(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT [AVG_All_Marks]  FROM Marks";
            CommandNew.Connection = Connection_SQL;

            SqlDataReader Reader = CommandNew.ExecuteReader();


            while (Reader.Read())
            {
                Console.WriteLine();
                //Console.WriteLine( Reader["Surname"] + " " + Reader["Name"].ToString()  );

               
                    Console.Write(Reader[0] + " |\t ");
                
                Console.WriteLine();
            }
            Reader.Close();
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }
        // 4
        static void Check_Avg_Exactly(SqlConnection Connection_SQL, double mark)
        {
            SqlParameter Paramentr_New = new SqlParameter("mark", System.Data.SqlDbType.NVarChar);
            Paramentr_New.Value = mark;
            SqlCommand Command_New = new SqlCommand("SELECT [Surname], [Name], [SecName] FROM Marks WHERE [AVG_All_Marks] <= @mark");
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
        // 5
        static void Read_All_MIN_SUBJ(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT [NameOfMin] FROM Marks GROUP BY [NameOfMin]";
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
        // 1
        static void Read_Min(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MIN(AVG_All_Marks)  FROM Marks";
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
        // 2
        static void Read_Max(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT MAX(AVG_All_Marks)  FROM Marks";
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
        // 3
        static void Read_Exac_MIN(SqlConnection Connection_SQL, string NameOfMin)
        {
            SqlParameter Paramentr_New = new SqlParameter("NameOfMin", System.Data.SqlDbType.NVarChar);
            Paramentr_New.Value = NameOfMin;
            SqlCommand Command_New = new SqlCommand("SELECT COUNT(Name) FROM Marks WHERE [NameOfMin] = @NameOfMin");
            Command_New.Parameters.Add(Paramentr_New);
            Command_New.Connection = Connection_SQL;

            Console.WriteLine("\n\nStudents count with minimal mark on this subject => " + Command_New.ExecuteScalar().ToString());
            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }
        // 4
        static void Read_Exac_MAX(SqlConnection Connection_SQL, string NameOfMax)
        {
            SqlParameter Paramentr_New = new SqlParameter("NameOfMax", System.Data.SqlDbType.NVarChar);
            Paramentr_New.Value = NameOfMax;
            SqlCommand Command_New = new SqlCommand("SELECT COUNT(Name) FROM Marks WHERE [NameOfMax] = @NameOfMax");
            Command_New.Parameters.Add(Paramentr_New);
            Command_New.Connection = Connection_SQL;

            Console.WriteLine("\n\nStudents count with minimal mark on this subject => " + Command_New.ExecuteScalar().ToString());

            Console.WriteLine("\n\nPress any key... ");
            Console.ReadKey(true);
        }
        // 5
        static void Read_Count_In_All_Groups(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT Name_Group AS [Group], COUNT(M.Name) AS [People There] FROM Marks M WHERE M.Name_Group IN ( SELECT Name_Group FROM Marks GROUP BY Name_Group ) GROUP BY Name_Group ORDER BY [People There] DESC";
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
        }
        // 6
        static void Read_AVG_Group(SqlConnection Connection_SQL)
        {
            SqlCommand CommandNew = new SqlCommand();
            CommandNew.CommandText = "SELECT Name_Group AS [Group], AVG(AVG_All_Marks) AS [AVG In Group] FROM Marks M WHERE M.Name_Group IN (SELECT Name_Group FROM Marks GROUP BY Name_Group) GROUP BY Name_Group ORDER BY [AVG In Group] DESC";
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
        }
        #endregion
    }
}
