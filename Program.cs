using System;
using MySql.Data.MySqlClient; // install correct package through  "Tools/Manage nutGet Packages" and then search up MySQL. (For Visual Studio Users intructions)


namespace mysqlconnection
{
    class MainFunction
    {
        static MySqlConnection connection;

        public static void Connect(string user, string password, string database)
        {
            connection = new MySqlConnection();

            try
            {
                connection.ConnectionString = "server = localhost; User Id = " + user + "; " +
                    "Persist Security Info = True; database = " + database + "; Password = " + password;
                connection.Open();
                Console.WriteLine("Connection Confirmed!");
            }

            catch (Exception e)
            {
                Console.WriteLine("Connection has failed " + e.ToString());
            }
        }
        public static void Main()
        {
            Connect("root", "password", "database"); // Change password and database to your db password and your db name, leave root
            connection.Close();
            Console.WriteLine($"Connection Information: {connection}"); //Ignore, useless really if you don't want it
        }
    }
}
