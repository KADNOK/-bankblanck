using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DBConn.Connect();

            UpdateClient();
            clientGridView.DataSource = clientTable;

            UpdateHabitation();
            habitationGridView.DataSource = habitationTable;

            UpdateAccount();
            accountGridView.DataSource = accountTable;

            UpdateCard();
            cardGridView.DataSource = cardTable;

            UpdateNumber();
            numberGridView.DataSource = numberTable;
        }

        public static DataTable clientTable = new DataTable();

        private void UpdateClient()
        {
            try
            {
                DBConn.cmd.CommandText = "SELECT * FROM `Client`";
                clientTable.Clear();
                DBConn.adapter.SelectCommand = DBConn.cmd;
                DBConn.adapter.Fill(clientTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        public static DataTable habitationTable = new DataTable();

        private void UpdateHabitation()
        {
            try
            {
                DBConn.cmd.CommandText = "SELECT * FROM `Habitation`";
                habitationTable.Clear();
                DBConn.adapter.SelectCommand = DBConn.cmd;
                DBConn.adapter.Fill(habitationTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        public static DataTable accountTable = new DataTable();

        private void UpdateAccount()
        {
            try
            {
                DBConn.cmd.CommandText = "SELECT * FROM `Account`";
                accountTable.Clear();
                DBConn.adapter.SelectCommand = DBConn.cmd;
                DBConn.adapter.Fill(accountTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        public static DataTable cardTable = new DataTable();

        private void UpdateCard()
        {
            try
            {
                DBConn.cmd.CommandText = "SELECT * FROM `Registration card`";
                cardTable.Clear();
                DBConn.adapter.SelectCommand = DBConn.cmd;
                DBConn.adapter.Fill(cardTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        public static DataTable numberTable = new DataTable();

        private void UpdateNumber()
        {
            try
            {
                DBConn.cmd.CommandText = "SELECT * FROM `Number`";
                numberTable.Clear();
                DBConn.adapter.SelectCommand = DBConn.cmd;
                DBConn.adapter.Fill(numberTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
