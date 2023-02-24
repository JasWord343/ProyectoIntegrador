namespace ProyectoIntegrador.GUI
{
    partial class UserManagment_GUI
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
            this.Panel_User = new System.Windows.Forms.Panel();
            this.PIC_Fondo_User = new System.Windows.Forms.PictureBox();
            this.Panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Fondo_User)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_User
            // 
            this.Panel_User.Controls.Add(this.PIC_Fondo_User);
            this.Panel_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_User.Location = new System.Drawing.Point(0, 0);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(1280, 580);
            this.Panel_User.TabIndex = 0;
            // 
            // PIC_Fondo_User
            // 
            this.PIC_Fondo_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC_Fondo_User.Image = global::ProyectoIntegrador.Properties.Resources.EMPLEADO;
            this.PIC_Fondo_User.Location = new System.Drawing.Point(0, 0);
            this.PIC_Fondo_User.Name = "PIC_Fondo_User";
            this.PIC_Fondo_User.Size = new System.Drawing.Size(1280, 580);
            this.PIC_Fondo_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Fondo_User.TabIndex = 0;
            this.PIC_Fondo_User.TabStop = false;
            // 
            // UserManagment_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 580);
            this.Controls.Add(this.Panel_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagment_GUI";
            this.Text = "UserManagment_GUI";
            this.Panel_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Fondo_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_User;
        private System.Windows.Forms.PictureBox PIC_Fondo_User;
    }
}