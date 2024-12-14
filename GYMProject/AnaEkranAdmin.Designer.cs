﻿namespace GYMProject
{
    partial class AnaEkranAdmin
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
            newMemberButton = new Button();
            equipmentButton = new Button();
            memberList = new Button();
            LogOutButton = new Button();
            exitbutton = new Button();
            SuspendLayout();
            // 
            // newMemberButton
            // 
            newMemberButton.BackgroundImage = Properties.Resources.add_group__1_;
            newMemberButton.BackgroundImageLayout = ImageLayout.None;
            newMemberButton.Location = new Point(36, 37);
            newMemberButton.Margin = new Padding(3, 4, 3, 4);
            newMemberButton.Name = "newMemberButton";
            newMemberButton.Size = new Size(167, 70);
            newMemberButton.TabIndex = 0;
            newMemberButton.Text = "New Member";
            newMemberButton.TextAlign = ContentAlignment.MiddleRight;
            newMemberButton.UseVisualStyleBackColor = true;
            newMemberButton.Click += newMemberButton_Click;
            // 
            // equipmentButton
            // 
            equipmentButton.BackgroundImage = Properties.Resources.gym;
            equipmentButton.BackgroundImageLayout = ImageLayout.None;
            equipmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            equipmentButton.Location = new Point(467, 37);
            equipmentButton.Margin = new Padding(3, 4, 3, 4);
            equipmentButton.Name = "equipmentButton";
            equipmentButton.Size = new Size(175, 70);
            equipmentButton.TabIndex = 1;
            equipmentButton.Text = "Equipments";
            equipmentButton.TextAlign = ContentAlignment.MiddleRight;
            equipmentButton.UseVisualStyleBackColor = true;
            equipmentButton.Click += button1_Click;
            // 
            // memberList
            // 
            memberList.BackgroundImage = Properties.Resources.file;
            memberList.BackgroundImageLayout = ImageLayout.None;
            memberList.Location = new Point(247, 37);
            memberList.Margin = new Padding(3, 4, 3, 4);
            memberList.Name = "memberList";
            memberList.Size = new Size(175, 70);
            memberList.TabIndex = 2;
            memberList.Text = "View Members";
            memberList.TextAlign = ContentAlignment.MiddleRight;
            memberList.UseVisualStyleBackColor = true;
            memberList.Click += memberList_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackgroundImage = Properties.Resources.logout;
            LogOutButton.BackgroundImageLayout = ImageLayout.None;
            LogOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutButton.Location = new Point(613, 515);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(149, 73);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log Out";
            LogOutButton.TextAlign = ContentAlignment.MiddleRight;
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // exitbutton
            // 
            exitbutton.BackgroundImage = Properties.Resources.exit;
            exitbutton.BackgroundImageLayout = ImageLayout.None;
            exitbutton.ImageAlign = ContentAlignment.MiddleLeft;
            exitbutton.Location = new Point(784, 515);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(118, 73);
            exitbutton.TabIndex = 4;
            exitbutton.Text = "Exit";
            exitbutton.TextAlign = ContentAlignment.MiddleRight;
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += button1_Click_2;
            // 
            // AnaEkranAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(exitbutton);
            Controls.Add(LogOutButton);
            Controls.Add(memberList);
            Controls.Add(equipmentButton);
            Controls.Add(newMemberButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnaEkranAdmin";
            Text = "AnaEkranAdmin";
            Load += AnaEkranAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newMemberButton;
        private Button equipmentButton;
        private Button memberList;
        private Button LogOutButton;
        private Button exitbutton;
    }
}