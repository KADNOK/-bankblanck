using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appk
{
    internal class DBConn
    {
        static private string connString = "server=MySQL-8.2; user=root; password=;database=hotel";

        static MySqlConnection conn;
        static public MySqlCommand cmd;
        static public MySqlDataAdapter adapter;

        public static void Connect()
        {
            try
            {
                conn = new MySqlConnection(connString);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                adapter = new MySqlDataAdapter(cmd);

                MessageBox.Show("Соединение с базой данных установлено", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
            }
        }

        public static void Close()
        {
            conn.Close();
        }
    }
}
