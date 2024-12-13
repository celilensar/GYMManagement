namespace GYMProject
{
    partial class NewMember
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
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            genderComboBox = new ComboBox();
            genderLabel = new Label();
            ageCounter = new NumericUpDown();
            ageLabel = new Label();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            roleComboBox = new ComboBox();
            roleLabel = new Label();
            membershipTypeComboBox = new ComboBox();
            membershipTypeLabel = new Label();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ageCounter).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(414, 38);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(234, 27);
            firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(243, 41);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(414, 84);
            lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(234, 27);
            lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(243, 91);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.Click += lastNameLabel_Click;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(414, 135);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(234, 28);
            genderComboBox.TabIndex = 4;
            genderComboBox.SelectedIndexChanged += genderComboBox_SelectedIndexChanged;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(243, 143);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Gender";
            genderLabel.Click += genderLabel_Click;
            // 
            // ageCounter
            // 
            ageCounter.Location = new Point(414, 193);
            ageCounter.Margin = new Padding(3, 4, 3, 4);
            ageCounter.Name = "ageCounter";
            ageCounter.Size = new Size(50, 27);
            ageCounter.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(243, 195);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(36, 20);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(414, 246);
            phoneNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(234, 27);
            phoneNumberTextBox.TabIndex = 8;
            phoneNumberTextBox.TextChanged += phoneNumberTextBox_TextChanged;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(243, 249);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Phone Number";
            phoneNumberLabel.Click += phoneNumberLabel_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(414, 293);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 27);
            emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(243, 300);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(414, 450);
            addressTextBox.Margin = new Padding(3, 4, 3, 4);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(234, 63);
            addressTextBox.TabIndex = 12;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(243, 453);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Address";
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Admin", "Customer" });
            roleComboBox.Location = new Point(414, 349);
            roleComboBox.Margin = new Padding(3, 4, 3, 4);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(234, 28);
            roleComboBox.TabIndex = 14;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(243, 352);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(39, 20);
            roleLabel.TabIndex = 15;
            roleLabel.Text = "Role";
            // 
            // membershipTypeComboBox
            // 
            membershipTypeComboBox.FormattingEnabled = true;
            membershipTypeComboBox.Items.AddRange(new object[] { "Month", "Year" });
            membershipTypeComboBox.Location = new Point(414, 402);
            membershipTypeComboBox.Margin = new Padding(3, 4, 3, 4);
            membershipTypeComboBox.Name = "membershipTypeComboBox";
            membershipTypeComboBox.Size = new Size(73, 28);
            membershipTypeComboBox.TabIndex = 16;
            // 
            // membershipTypeLabel
            // 
            membershipTypeLabel.AutoSize = true;
            membershipTypeLabel.Location = new Point(243, 402);
            membershipTypeLabel.Name = "membershipTypeLabel";
            membershipTypeLabel.Size = new Size(127, 20);
            membershipTypeLabel.TabIndex = 17;
            membershipTypeLabel.Text = "Membership Type";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(414, 542);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 31);
            saveButton.TabIndex = 18;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(saveButton);
            Controls.Add(membershipTypeLabel);
            Controls.Add(membershipTypeComboBox);
            Controls.Add(roleLabel);
            Controls.Add(roleComboBox);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(ageLabel);
            Controls.Add(ageCounter);
            Controls.Add(genderLabel);
            Controls.Add(genderComboBox);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewMember";
            Text = "NewMember";
            ((System.ComponentModel.ISupportInitialize)ageCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private ComboBox genderComboBox;
        private Label genderLabel;
        private NumericUpDown ageCounter;
        private Label ageLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private ComboBox roleComboBox;
        private Label roleLabel;
        private ComboBox membershipTypeComboBox;
        private Label membershipTypeLabel;
        private Button saveButton;
    }
}