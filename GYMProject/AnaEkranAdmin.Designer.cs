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
            memberListButton = new Button();
            equipmentButton = new Button();
            SuspendLayout();
            // 
            // newMemberButton
            // 
<<<<<<< HEAD
            newMemberButton.Image = Properties.Resources.add_group__1_;
            newMemberButton.ImageAlign = ContentAlignment.MiddleLeft;
            newMemberButton.Location = new Point(12, 13);
            newMemberButton.Margin = new Padding(3, 4, 3, 4);
            newMemberButton.Name = "newMemberButton";
            newMemberButton.Size = new Size(173, 69);
=======
            newMemberButton.Location = new Point(47, 41);
            newMemberButton.Margin = new Padding(3, 4, 3, 4);
            newMemberButton.Name = "newMemberButton";
            newMemberButton.Size = new Size(135, 31);
>>>>>>> Eren
            newMemberButton.TabIndex = 0;
            newMemberButton.Text = "New Member";
            newMemberButton.TextAlign = ContentAlignment.MiddleRight;
            newMemberButton.UseVisualStyleBackColor = true;
            newMemberButton.Click += newMemberButton_Click;
            // 
            // memberListButton
            // 
            memberListButton.Location = new Point(47, 158);
            memberListButton.Margin = new Padding(3, 4, 3, 4);
            memberListButton.Name = "memberListButton";
            memberListButton.Size = new Size(135, 31);
            memberListButton.TabIndex = 1;
            memberListButton.Text = "View Members";
            memberListButton.UseVisualStyleBackColor = true;
            memberListButton.Click += memberListButton_Click;
            // 
            // equipmentButton
            // 
            equipmentButton.Location = new Point(47, 97);
            equipmentButton.Name = "equipmentButton";
            equipmentButton.Size = new Size(135, 29);
            equipmentButton.TabIndex = 2;
            equipmentButton.Text = "Equipments";
            equipmentButton.UseVisualStyleBackColor = true;
            equipmentButton.Click += equipmentButton_Click;
            // 
            // AnaEkranAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
=======
            ClientSize = new Size(914, 600);
            Controls.Add(equipmentButton);
            Controls.Add(memberListButton);
>>>>>>> Eren
            Controls.Add(newMemberButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnaEkranAdmin";
            Text = "AnaEkranAdmin";
            Load += AnaEkranAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newMemberButton;
        private Button memberListButton;
        private Button equipmentButton;
    }
}