using System;
using MySql.Data.MySqlClient;


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
                Console.WriteLine("Succesfully connected!");
            }

            catch (Exception e)
            {
                Console.WriteLine("Not Successful! due to " + e.ToString());
            }
        }
        public static void Main()
        {
            Connect("root", "root54321", "Car");
            connection.Close();
            Console.WriteLine($"Connection Confirmed: {connection}");
        }
    }
}