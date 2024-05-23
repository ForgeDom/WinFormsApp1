
namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            registerlabel = new Label();
            buttonLogin = new Button();
            passField = new TextBox();
            loginField = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(registerlabel);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // registerlabel
            // 
            registerlabel.AutoSize = true;
            registerlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            registerlabel.ForeColor = SystemColors.AppWorkspace;
            registerlabel.Location = new Point(364, 398);
            registerlabel.Name = "registerlabel";
            registerlabel.Size = new Size(85, 15);
            registerlabel.TabIndex = 4;
            registerlabel.Text = "Go to register";
            registerlabel.Click += registerlabel_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(335, 346);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(137, 36);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Sign in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.MouseClick += buttonLogin_MouseClick;
            // 
            // passField
            // 
            passField.Font = new Font("Segoe UI", 16F);
            passField.Location = new Point(293, 249);
            passField.Name = "passField";
            passField.PlaceholderText = "Password";
            passField.Size = new Size(214, 36);
            passField.TabIndex = 2;
            passField.TextAlign = HorizontalAlignment.Center;
            passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            loginField.Font = new Font("Segoe UI", 16F);
            loginField.Location = new Point(292, 155);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.PlaceholderText = "Login";
            loginField.Size = new Size(214, 46);
            loginField.TabIndex = 1;
            loginField.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 100);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.Font = new Font("Segoe UI", 28F);
            label2.Location = new Point(327, 26);
            label2.Name = "label2";
            label2.Size = new Size(137, 51);
            label2.TabIndex = 0;
            label2.Text = "Sign In";
            label2.Click += label2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckCredentials(loginField.Text, passField.Text))
            {
                MessageBox.Show("Ви успішно увійшли!");
                // Тут ви можете додати код для переходу на іншу форму або виконання інших дій
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            // Реалізуйте перевірку логіну та паролю тут
            // Наприклад, ви можете звернутися до бази даних для перевірки логіну та паролю
            // Поверніть true, якщо логін і пароль вірні, і false в іншому випадку
            return (username == "admin" && password == "password");
        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox passField;
        private TextBox loginField;
        private Button buttonLogin;
        private Label registerlabel;
    }
}