namespace WinFormsApp1
{
    partial class RegisterForm
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
            signinlabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            loginField = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            passField = new TextBox();
            userSurnameField = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(signinlabel);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 561);
            panel1.TabIndex = 1;
            // 
            // signinlabel
            // 
            signinlabel.AutoSize = true;
            signinlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            signinlabel.ForeColor = SystemColors.AppWorkspace;
            signinlabel.Location = new Point(352, 392);
            signinlabel.Name = "signinlabel";
            signinlabel.Size = new Size(93, 15);
            signinlabel.TabIndex = 8;
            signinlabel.Text = "Go to signing in";
            signinlabel.Click += signinlabel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password_lock_solid_svgrepo_com;
            pictureBox2.Location = new Point(431, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_default_svgrepo_com;
            pictureBox1.Location = new Point(94, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Segoe UI", 16F);
            loginField.Location = new Point(514, 218);
            loginField.Name = "loginField";
            loginField.PlaceholderText = "Login";
            loginField.Size = new Size(214, 36);
            loginField.TabIndex = 5;
            loginField.TextAlign = HorizontalAlignment.Center;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Segoe UI", 16F);
            userNameField.Location = new Point(177, 135);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.PlaceholderText = "Name";
            userNameField.Size = new Size(214, 46);
            userNameField.TabIndex = 4;
            userNameField.TextAlign = HorizontalAlignment.Center;
            userNameField.TextChanged += textBox1_TextChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Location = new Point(327, 342);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(137, 36);
            buttonRegister.TabIndex = 3;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Segoe UI", 16F);
            passField.Location = new Point(514, 135);
            passField.Name = "passField";
            passField.PlaceholderText = "Password";
            passField.Size = new Size(214, 36);
            passField.TabIndex = 2;
            passField.TextAlign = HorizontalAlignment.Center;
            passField.UseSystemPasswordChar = true;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Segoe UI", 16F);
            userSurnameField.Location = new Point(177, 218);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.PlaceholderText = "Surname";
            userSurnameField.Size = new Size(214, 46);
            userSurnameField.TabIndex = 1;
            userSurnameField.TextAlign = HorizontalAlignment.Center;
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
            label2.Size = new Size(153, 51);
            label2.TabIndex = 0;
            label2.Text = "Sign Up";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox loginField;
        private TextBox userNameField;
        private Button buttonRegister;
        private TextBox passField;
        private TextBox userSurnameField;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label signinlabel;
    }
}