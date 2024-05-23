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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                MessageBox.Show("Всі пункти мають бути заповнені");
                return;
            }
            if (userSurnameField.Text == "")
            {
                MessageBox.Show("Всі пункти мають бути заповнені");
                return;
            }
            if (loginField.Text == "")
            {
                MessageBox.Show("Всі пункти мають бути заповнені");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Всі пункти мають бути заповнені");
                return;
            }

            if (isUserExists())
                return;
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login,@pass,@name,@surname)", dataBase.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account has been created");
            }
            else
            {
                MessageBox.Show("Account has not been created");
            }
            dataBase.closeConnection();
        }

        public Boolean isUserExists()
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", dataBase.GetConnection());
            command.Parameters.Add("uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий користувач вже існує, змініть логін");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void signinlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
