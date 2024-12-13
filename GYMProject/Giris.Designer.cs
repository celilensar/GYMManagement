using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GYMProject
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(88, 103);
            userNameTextBox.Margin = new Padding(3, 4, 3, 4);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(174, 27);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(88, 207);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(174, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(88, 79);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(75, 20);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Username";
            userNameLabel.Click += userNameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(93, 183);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.MediumBlue;
            loginButton.ForeColor = SystemColors.ButtonFace;
            loginButton.Location = new Point(132, 269);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 31);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(userNameTextBox);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(passwordLabel);
            panel1.Location = new Point(298, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 321);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Giris";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label userNameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Panel panel1;
    }
}
