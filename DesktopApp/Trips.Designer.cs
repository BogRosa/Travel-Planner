﻿namespace DesktopApp
{
    partial class Trips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trips));
            sidebar = new FlowLayoutPanel();
            sidebarCont = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            btnTrips = new Button();
            btnUsers = new Button();
            btnRecommend = new Button();
            btnLogOut = new Button();
            sidebar.SuspendLayout();
            sidebarCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sidebar.BackColor = Color.FromArgb(124, 147, 195);
            sidebar.Controls.Add(sidebarCont);
            sidebar.Controls.Add(btnTrips);
            sidebar.Controls.Add(btnUsers);
            sidebar.Controls.Add(btnRecommend);
            sidebar.Dock = DockStyle.Fill;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(300, 894);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(300, 894);
            sidebar.TabIndex = 33;
            // 
            // sidebarCont
            // 
            sidebarCont.Controls.Add(label1);
            sidebarCont.Controls.Add(menuButton);
            sidebarCont.Location = new Point(3, 3);
            sidebarCont.Name = "sidebarCont";
            sidebarCont.Size = new Size(300, 92);
            sidebarCont.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 38);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(24, 27);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(51, 35);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            // 
            // btnTrips
            // 
            btnTrips.BackColor = Color.FromArgb(158, 184, 217);
            btnTrips.FlatAppearance.BorderSize = 0;
            btnTrips.FlatStyle = FlatStyle.Flat;
            btnTrips.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrips.ForeColor = Color.Transparent;
            btnTrips.Image = (Image)resources.GetObject("btnTrips.Image");
            btnTrips.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrips.Location = new Point(3, 101);
            btnTrips.Name = "btnTrips";
            btnTrips.Padding = new Padding(20, 0, 0, 0);
            btnTrips.Size = new Size(337, 88);
            btnTrips.TabIndex = 3;
            btnTrips.Text = "         Trips";
            btnTrips.TextAlign = ContentAlignment.MiddleLeft;
            btnTrips.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(124, 147, 195);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.Transparent;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 195);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(20, 0, 0, 0);
            btnUsers.Size = new Size(318, 88);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "         Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnRecommend
            // 
            btnRecommend.BackColor = Color.FromArgb(124, 147, 195);
            btnRecommend.FlatAppearance.BorderColor = Color.White;
            btnRecommend.FlatAppearance.BorderSize = 0;
            btnRecommend.FlatStyle = FlatStyle.Flat;
            btnRecommend.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecommend.ForeColor = Color.Transparent;
            btnRecommend.Image = Properties.Resources.group_48;
            btnRecommend.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecommend.Location = new Point(3, 289);
            btnRecommend.Name = "btnRecommend";
            btnRecommend.Padding = new Padding(20, 0, 0, 0);
            btnRecommend.Size = new Size(297, 88);
            btnRecommend.TabIndex = 3;
            btnRecommend.Text = "         Recommend";
            btnRecommend.TextAlign = ContentAlignment.MiddleLeft;
            btnRecommend.UseVisualStyleBackColor = false;
            btnRecommend.Click += btnRecommend_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(124, 147, 195);
            btnLogOut.FlatAppearance.BorderColor = Color.FromArgb(108, 162, 78);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Location = new Point(1204, 38);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(214, 57);
            btnLogOut.TabIndex = 34;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Trips
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 184, 217);
            ClientSize = new Size(1478, 894);
            Controls.Add(btnLogOut);
            Controls.Add(sidebar);
            Name = "Trips";
            Text = "Form1";
            sidebar.ResumeLayout(false);
            sidebarCont.ResumeLayout(false);
            sidebarCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel sidebarCont;
        private Label label1;
        private PictureBox menuButton;
        private Button btnTrips;
        private Button btnUsers;
        private Button btnRecommend;
        private Button btnLogOut;
    }
}