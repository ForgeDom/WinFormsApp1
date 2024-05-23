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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 46);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", dataBase.GetConnection());
            command.Parameters.Add("uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MySqlCommand commandDelete = new MySqlCommand("DELETE * FROM 'current_table'", dataBase.GetConnection());
                adapter.SelectCommand = commandDelete;
                MySqlCommand commandCurrentUser = new MySqlCommand("INSERT INTO 'current_table' (current_user) VALUES (@cU)", dataBase.GetConnection());
                command.Parameters.Add("cU", MySqlDbType.VarChar).Value = loginUser;
                adapter.SelectCommand = commandCurrentUser;
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("All spaces should be full");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
