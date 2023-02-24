namespace ProyectoIntegrador
{
    partial class PrincipalForm_GUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PNL_TOP_PRINCIPAL = new System.Windows.Forms.Panel();
            this.PIC_MINIMIZE = new System.Windows.Forms.PictureBox();
            this.PIC_Maximize = new System.Windows.Forms.PictureBox();
            this.PIC_EXIT = new System.Windows.Forms.PictureBox();
            this.Restore = new System.Windows.Forms.PictureBox();
            this.PNL_Menu = new System.Windows.Forms.Panel();
            this.PIC_LOGO = new System.Windows.Forms.PictureBox();
            this.BTN_USER_MANAGE = new System.Windows.Forms.Button();
            this.BTN_Recharge = new System.Windows.Forms.Button();
            this.PNL_Panel_Contenedor = new System.Windows.Forms.Panel();
            this.PIC_FONDO_WELCOME = new System.Windows.Forms.PictureBox();
            this.PNL_TOP_PRINCIPAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MINIMIZE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restore)).BeginInit();
            this.PNL_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGO)).BeginInit();
            this.PNL_Panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FONDO_WELCOME)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_TOP_PRINCIPAL
            // 
            this.PNL_TOP_PRINCIPAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(73)))));
            this.PNL_TOP_PRINCIPAL.Controls.Add(this.PIC_MINIMIZE);
            this.PNL_TOP_PRINCIPAL.Controls.Add(this.PIC_Maximize);
            this.PNL_TOP_PRINCIPAL.Controls.Add(this.PIC_EXIT);
            this.PNL_TOP_PRINCIPAL.Controls.Add(this.Restore);
            this.PNL_TOP_PRINCIPAL.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TOP_PRINCIPAL.Location = new System.Drawing.Point(0, 0);
            this.PNL_TOP_PRINCIPAL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNL_TOP_PRINCIPAL.Name = "PNL_TOP_PRINCIPAL";
            this.PNL_TOP_PRINCIPAL.Size = new System.Drawing.Size(1440, 50);
            this.PNL_TOP_PRINCIPAL.TabIndex = 0;
            this.PNL_TOP_PRINCIPAL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNL_TOP_PRINCIPAL_MouseDown);
            this.PNL_TOP_PRINCIPAL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_TOP_PRINCIPAL_MouseMove);
            // 
            // PIC_MINIMIZE
            // 
            this.PIC_MINIMIZE.Image = global::ProyectoIntegrador.Properties.Resources.minimizar_signo;
            this.PIC_MINIMIZE.Location = new System.Drawing.Point(1286, 9);
            this.PIC_MINIMIZE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_MINIMIZE.Name = "PIC_MINIMIZE";
            this.PIC_MINIMIZE.Size = new System.Drawing.Size(34, 38);
            this.PIC_MINIMIZE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_MINIMIZE.TabIndex = 2;
            this.PIC_MINIMIZE.TabStop = false;
            this.PIC_MINIMIZE.Click += new System.EventHandler(this.MINIMIZE_Click);
            // 
            // PIC_Maximize
            // 
            this.PIC_Maximize.Image = global::ProyectoIntegrador.Properties.Resources.maximize__1_;
            this.PIC_Maximize.Location = new System.Drawing.Point(1351, 9);
            this.PIC_Maximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_Maximize.Name = "PIC_Maximize";
            this.PIC_Maximize.Size = new System.Drawing.Size(34, 38);
            this.PIC_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_Maximize.TabIndex = 1;
            this.PIC_Maximize.TabStop = false;
            this.PIC_Maximize.Click += new System.EventHandler(this.EXTEND_Click);
            // 
            // PIC_EXIT
            // 
            this.PIC_EXIT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIC_EXIT.Image = global::ProyectoIntegrador.Properties.Resources.cruzar;
            this.PIC_EXIT.Location = new System.Drawing.Point(1406, 0);
            this.PIC_EXIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_EXIT.Name = "PIC_EXIT";
            this.PIC_EXIT.Size = new System.Drawing.Size(34, 50);
            this.PIC_EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_EXIT.TabIndex = 0;
            this.PIC_EXIT.TabStop = false;
            this.PIC_EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Restore
            // 
            this.Restore.Image = global::ProyectoIntegrador.Properties.Resources.minimize;
            this.Restore.Location = new System.Drawing.Point(1351, 9);
            this.Restore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(34, 38);
            this.Restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restore.TabIndex = 3;
            this.Restore.TabStop = false;
            this.Restore.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PNL_Menu
            // 
            this.PNL_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(197)))));
            this.PNL_Menu.Controls.Add(this.PIC_LOGO);
            this.PNL_Menu.Controls.Add(this.BTN_USER_MANAGE);
            this.PNL_Menu.Controls.Add(this.BTN_Recharge);
            this.PNL_Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_Menu.Location = new System.Drawing.Point(0, 775);
            this.PNL_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNL_Menu.Name = "PNL_Menu";
            this.PNL_Menu.Size = new System.Drawing.Size(1440, 125);
            this.PNL_Menu.TabIndex = 1;
            // 
            // PIC_LOGO
            // 
            this.PIC_LOGO.Image = global::ProyectoIntegrador.Properties.Resources.LOGO2;
            this.PIC_LOGO.Location = new System.Drawing.Point(3, -2);
            this.PIC_LOGO.Name = "PIC_LOGO";
            this.PIC_LOGO.Size = new System.Drawing.Size(179, 127);
            this.PIC_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_LOGO.TabIndex = 2;
            this.PIC_LOGO.TabStop = false;
            // 
            // BTN_USER_MANAGE
            // 
            this.BTN_USER_MANAGE.AutoSize = true;
            this.BTN_USER_MANAGE.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.Btn;
            this.BTN_USER_MANAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_USER_MANAGE.FlatAppearance.BorderSize = 0;
            this.BTN_USER_MANAGE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BTN_USER_MANAGE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.BTN_USER_MANAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_USER_MANAGE.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_USER_MANAGE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_USER_MANAGE.Location = new System.Drawing.Point(833, 8);
            this.BTN_USER_MANAGE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_USER_MANAGE.Name = "BTN_USER_MANAGE";
            this.BTN_USER_MANAGE.Size = new System.Drawing.Size(247, 92);
            this.BTN_USER_MANAGE.TabIndex = 1;
            this.BTN_USER_MANAGE.Text = "Gestion de Usuarios";
            this.BTN_USER_MANAGE.UseVisualStyleBackColor = true;
            this.BTN_USER_MANAGE.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Recharge
            // 
            this.BTN_Recharge.AutoSize = true;
            this.BTN_Recharge.BackgroundImage = global::ProyectoIntegrador.Properties.Resources.Btn;
            this.BTN_Recharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Recharge.FlatAppearance.BorderSize = 0;
            this.BTN_Recharge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BTN_Recharge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.BTN_Recharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recharge.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Recharge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Recharge.Location = new System.Drawing.Point(432, 8);
            this.BTN_Recharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Recharge.Name = "BTN_Recharge";
            this.BTN_Recharge.Size = new System.Drawing.Size(214, 92);
            this.BTN_Recharge.TabIndex = 0;
            this.BTN_Recharge.Text = "Recargas";
            this.BTN_Recharge.UseVisualStyleBackColor = true;
            this.BTN_Recharge.Click += new System.EventHandler(this.BTN_Recharge_Click);
            // 
            // PNL_Panel_Contenedor
            // 
            this.PNL_Panel_Contenedor.Controls.Add(this.PIC_FONDO_WELCOME);
            this.PNL_Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Panel_Contenedor.Location = new System.Drawing.Point(0, 50);
            this.PNL_Panel_Contenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNL_Panel_Contenedor.Name = "PNL_Panel_Contenedor";
            this.PNL_Panel_Contenedor.Size = new System.Drawing.Size(1440, 725);
            this.PNL_Panel_Contenedor.TabIndex = 2;
            // 
            // PIC_FONDO_WELCOME
            // 
            this.PIC_FONDO_WELCOME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC_FONDO_WELCOME.Image = global::ProyectoIntegrador.Properties.Resources.BIENVENIDO1;
            this.PIC_FONDO_WELCOME.Location = new System.Drawing.Point(0, 0);
            this.PIC_FONDO_WELCOME.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_FONDO_WELCOME.Name = "PIC_FONDO_WELCOME";
            this.PIC_FONDO_WELCOME.Size = new System.Drawing.Size(1440, 725);
            this.PIC_FONDO_WELCOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_FONDO_WELCOME.TabIndex = 0;
            this.PIC_FONDO_WELCOME.TabStop = false;
            this.PIC_FONDO_WELCOME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PIC_FONDO_WELCOME_MouseDown);
            this.PIC_FONDO_WELCOME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PIC_FONDO_WELCOME_MouseMove);
            // 
            // PrincipalForm_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.PNL_Panel_Contenedor);
            this.Controls.Add(this.PNL_Menu);
            this.Controls.Add(this.PNL_TOP_PRINCIPAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrincipalForm_GUI";
            this.Text = "TRANSINT";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrincipalForm_GUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PrincipalForm_GUI_MouseMove);
            this.PNL_TOP_PRINCIPAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MINIMIZE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restore)).EndInit();
            this.PNL_Menu.ResumeLayout(false);
            this.PNL_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_LOGO)).EndInit();
            this.PNL_Panel_Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FONDO_WELCOME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_TOP_PRINCIPAL;
        private System.Windows.Forms.PictureBox Restore;
        private System.Windows.Forms.PictureBox PIC_MINIMIZE;
        private System.Windows.Forms.PictureBox PIC_Maximize;
        private System.Windows.Forms.PictureBox PIC_EXIT;
        private System.Windows.Forms.Panel PNL_Menu;
        private System.Windows.Forms.Button BTN_UserManagment;
        private System.Windows.Forms.Button BTN_Recharge;
        private System.Windows.Forms.Panel PNL_Panel_Contenedor;
        private System.Windows.Forms.PictureBox PIC_FONDO_WELCOME;
        private System.Windows.Forms.Button BTN_USER_MANAGE;
        private System.Windows.Forms.PictureBox PIC_LOGO;
    }
}

