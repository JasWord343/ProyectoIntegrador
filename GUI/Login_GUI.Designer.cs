namespace ProyectoIntegrador.GUI
{
    partial class Login_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_GUI));
            this.TXT_USERNAME = new System.Windows.Forms.Label();
            this.TXR_PASSWORD = new System.Windows.Forms.Label();
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.PIC_PASSWORD = new System.Windows.Forms.PictureBox();
            this.PIC_USER_LOGIN = new System.Windows.Forms.PictureBox();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.PIC_LOGIN = new System.Windows.Forms.PictureBox();
            this.PNL_LOGIN_TOP = new System.Windows.Forms.Panel();
            this.LBL_LOGIN = new System.Windows.Forms.Label();
            this.PIC_MINIMIZE_LOGIN = new System.Windows.Forms.PictureBox();
            this.PIC_EXIT_LOGIN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PASSWORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_USER_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGIN)).BeginInit();
            this.PNL_LOGIN_TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MINIMIZE_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EXIT_LOGIN)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_USERNAME
            // 
            this.TXT_USERNAME.AutoSize = true;
            this.TXT_USERNAME.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_USERNAME.Location = new System.Drawing.Point(495, 118);
            this.TXT_USERNAME.Name = "TXT_USERNAME";
            this.TXT_USERNAME.Size = new System.Drawing.Size(149, 31);
            this.TXT_USERNAME.TabIndex = 1;
            this.TXT_USERNAME.Text = "USERNAME";
            // 
            // TXR_PASSWORD
            // 
            this.TXR_PASSWORD.AutoSize = true;
            this.TXR_PASSWORD.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXR_PASSWORD.Location = new System.Drawing.Point(495, 274);
            this.TXR_PASSWORD.Name = "TXR_PASSWORD";
            this.TXR_PASSWORD.Size = new System.Drawing.Size(152, 31);
            this.TXR_PASSWORD.TabIndex = 2;
            this.TXR_PASSWORD.Text = "PASSWORD";
            this.TXR_PASSWORD.Click += new System.EventHandler(this.PASSWORD_Click);
            // 
            // TXT_USER
            // 
            this.TXT_USER.Location = new System.Drawing.Point(423, 180);
            this.TXT_USER.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(242, 26);
            this.TXT_USER.TabIndex = 3;
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Location = new System.Drawing.Point(423, 332);
            this.TXT_PASSWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.Size = new System.Drawing.Size(242, 26);
            this.TXT_PASSWORD.TabIndex = 4;
            // 
            // PIC_PASSWORD
            // 
            this.PIC_PASSWORD.Image = global::ProyectoIntegrador.Properties.Resources.padlock;
            this.PIC_PASSWORD.Location = new System.Drawing.Point(423, 250);
            this.PIC_PASSWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_PASSWORD.Name = "PIC_PASSWORD";
            this.PIC_PASSWORD.Size = new System.Drawing.Size(68, 75);
            this.PIC_PASSWORD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_PASSWORD.TabIndex = 7;
            this.PIC_PASSWORD.TabStop = false;
            // 
            // PIC_USER_LOGIN
            // 
            this.PIC_USER_LOGIN.Image = global::ProyectoIntegrador.Properties.Resources.profile_user;
            this.PIC_USER_LOGIN.Location = new System.Drawing.Point(421, 98);
            this.PIC_USER_LOGIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_USER_LOGIN.Name = "PIC_USER_LOGIN";
            this.PIC_USER_LOGIN.Size = new System.Drawing.Size(68, 75);
            this.PIC_USER_LOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_USER_LOGIN.TabIndex = 6;
            this.PIC_USER_LOGIN.TabStop = false;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.login34;
            this.BTN_LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_LOGIN.FlatAppearance.BorderSize = 0;
            this.BTN_LOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.BTN_LOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.BTN_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.Location = new System.Drawing.Point(423, 424);
            this.BTN_LOGIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(240, 49);
            this.BTN_LOGIN.TabIndex = 5;
            this.BTN_LOGIN.Text = "LOGIN";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            this.BTN_LOGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // PIC_LOGIN
            // 
            this.PIC_LOGIN.Image = global::ProyectoIntegrador.Properties.Resources.login;
            this.PIC_LOGIN.Location = new System.Drawing.Point(0, 98);
            this.PIC_LOGIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_LOGIN.Name = "PIC_LOGIN";
            this.PIC_LOGIN.Size = new System.Drawing.Size(403, 388);
            this.PIC_LOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_LOGIN.TabIndex = 0;
            this.PIC_LOGIN.TabStop = false;
            // 
            // PNL_LOGIN_TOP
            // 
            this.PNL_LOGIN_TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(73)))));
            this.PNL_LOGIN_TOP.Controls.Add(this.LBL_LOGIN);
            this.PNL_LOGIN_TOP.Controls.Add(this.PIC_MINIMIZE_LOGIN);
            this.PNL_LOGIN_TOP.Controls.Add(this.PIC_EXIT_LOGIN);
            this.PNL_LOGIN_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_LOGIN_TOP.Location = new System.Drawing.Point(0, 0);
            this.PNL_LOGIN_TOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNL_LOGIN_TOP.Name = "PNL_LOGIN_TOP";
            this.PNL_LOGIN_TOP.Size = new System.Drawing.Size(880, 35);
            this.PNL_LOGIN_TOP.TabIndex = 8;
            // 
            // LBL_LOGIN
            // 
            this.LBL_LOGIN.AutoSize = true;
            this.LBL_LOGIN.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_LOGIN.Location = new System.Drawing.Point(3, 0);
            this.LBL_LOGIN.Name = "LBL_LOGIN";
            this.LBL_LOGIN.Size = new System.Drawing.Size(122, 19);
            this.LBL_LOGIN.TabIndex = 10;
            this.LBL_LOGIN.Text = "LOGIN SCREEN";
            // 
            // PIC_MINIMIZE_LOGIN
            // 
            this.PIC_MINIMIZE_LOGIN.Image = global::ProyectoIntegrador.Properties.Resources.minimizar_signo;
            this.PIC_MINIMIZE_LOGIN.Location = new System.Drawing.Point(793, -2);
            this.PIC_MINIMIZE_LOGIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_MINIMIZE_LOGIN.Name = "PIC_MINIMIZE_LOGIN";
            this.PIC_MINIMIZE_LOGIN.Size = new System.Drawing.Size(34, 38);
            this.PIC_MINIMIZE_LOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_MINIMIZE_LOGIN.TabIndex = 9;
            this.PIC_MINIMIZE_LOGIN.TabStop = false;
            this.PIC_MINIMIZE_LOGIN.Click += new System.EventHandler(this.MINIMIZE_Click);
            // 
            // PIC_EXIT_LOGIN
            // 
            this.PIC_EXIT_LOGIN.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIC_EXIT_LOGIN.Image = global::ProyectoIntegrador.Properties.Resources.cruzar;
            this.PIC_EXIT_LOGIN.Location = new System.Drawing.Point(846, 0);
            this.PIC_EXIT_LOGIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_EXIT_LOGIN.Name = "PIC_EXIT_LOGIN";
            this.PIC_EXIT_LOGIN.Size = new System.Drawing.Size(34, 35);
            this.PIC_EXIT_LOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_EXIT_LOGIN.TabIndex = 1;
            this.PIC_EXIT_LOGIN.TabStop = false;
            this.PIC_EXIT_LOGIN.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Login_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(148)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.PNL_LOGIN_TOP);
            this.Controls.Add(this.PIC_PASSWORD);
            this.Controls.Add(this.PIC_USER_LOGIN);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.TXT_PASSWORD);
            this.Controls.Add(this.TXT_USER);
            this.Controls.Add(this.TXR_PASSWORD);
            this.Controls.Add(this.TXT_USERNAME);
            this.Controls.Add(this.PIC_LOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PASSWORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_USER_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGIN)).EndInit();
            this.PNL_LOGIN_TOP.ResumeLayout(false);
            this.PNL_LOGIN_TOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MINIMIZE_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EXIT_LOGIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_LOGIN;
        private System.Windows.Forms.Label TXT_USERNAME;
        private System.Windows.Forms.Label TXR_PASSWORD;
        private System.Windows.Forms.TextBox TXT_USER;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.PictureBox PIC_USER_LOGIN;
        private System.Windows.Forms.PictureBox PIC_PASSWORD;
        private System.Windows.Forms.Panel PNL_LOGIN_TOP;
        private System.Windows.Forms.PictureBox PIC_EXIT_LOGIN;
        private System.Windows.Forms.PictureBox PIC_MINIMIZE_LOGIN;
        private System.Windows.Forms.Label LBL_LOGIN;
    }
}