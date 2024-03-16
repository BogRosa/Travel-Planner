namespace DesktopApp
{
    partial class LogIn
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
            btnLogIn = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(158, 184, 217);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(427, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 623);
            panel1.TabIndex = 0;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(124, 147, 195);
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(108, 162, 78);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.ButtonHighlight;
            btnLogIn.Location = new Point(113, 483);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(391, 80);
            btnLogIn.TabIndex = 36;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 388);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 60);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(203, 318);
            label3.Name = "label3";
            label3.Size = new Size(215, 49);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 231);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(352, 60);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(196, 161);
            label2.Name = "label2";
            label2.Size = new Size(230, 49);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(207, 53);
            label1.Name = "label1";
            label1.Size = new Size(207, 74);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 147, 195);
            ClientSize = new Size(1478, 894);
            Controls.Add(panel1);
            Name = "LogIn";
            Text = "LogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Button btnLogIn;
    }
}