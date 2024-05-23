using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name= "", category = "", number = "", address = "";
            try
            {
                name = textBox2.Text;
                category = textBox3.Text;
                number = textBox4.Text;
                address = textBox5.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand getcurrentuser = new MySqlCommand("SELECT 'current_user' FROM 'current_table'", dataBase.GetConnection());
            adapter.SelectCommand = getcurrentuser;
            adapter.Fill(table);

            MySqlCommand command = new MySqlCommand("INSERT INTO 'members' (name, category, number, address, user_link) VALUES (@mN, @mC, @mNum, @mA, @user_link)", dataBase.GetConnection());
            command.Parameters.Add("mN", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("mC", MySqlDbType.VarChar).Value = category;
            command.Parameters.Add("mNum", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("mA", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("user_link",MySqlDbType.VarChar).Value= table.ToString();
            adapter.SelectCommand = command;
        }
    }
}