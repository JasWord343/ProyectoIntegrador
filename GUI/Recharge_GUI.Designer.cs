namespace ProyectoIntegrador.GUI
{
    partial class Recharge_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BNT_Recharge_Finish = new System.Windows.Forms.Button();
            this.BTN_100 = new System.Windows.Forms.Button();
            this.BTN_50 = new System.Windows.Forms.Button();
            this.BTN_20 = new System.Windows.Forms.Button();
            this.BTN_10 = new System.Windows.Forms.Button();
            this.LBL_MontoRecarga = new System.Windows.Forms.Label();
            this.PIC_Fondo_Recharge = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Fondo_Recharge)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BNT_Recharge_Finish);
            this.panel1.Controls.Add(this.BTN_100);
            this.panel1.Controls.Add(this.BTN_50);
            this.panel1.Controls.Add(this.BTN_20);
            this.panel1.Controls.Add(this.BTN_10);
            this.panel1.Controls.Add(this.LBL_MontoRecarga);
            this.panel1.Controls.Add(this.PIC_Fondo_Recharge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 725);
            this.panel1.TabIndex = 0;
            // 
            // BNT_Recharge_Finish
            // 
            this.BNT_Recharge_Finish.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNT_Recharge_Finish.Location = new System.Drawing.Point(648, 585);
            this.BNT_Recharge_Finish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BNT_Recharge_Finish.Name = "BNT_Recharge_Finish";
            this.BNT_Recharge_Finish.Size = new System.Drawing.Size(202, 112);
            this.BNT_Recharge_Finish.TabIndex = 6;
            this.BNT_Recharge_Finish.Text = "RECARGAR";
            this.BNT_Recharge_Finish.UseVisualStyleBackColor = true;
            this.BNT_Recharge_Finish.Click += new System.EventHandler(this.Recharge_Finish_Click);
            // 
            // BTN_100
            // 
            this.BTN_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_100.FlatAppearance.BorderSize = 0;
            this.BTN_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_100.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.BTN_100.Location = new System.Drawing.Point(1024, 235);
            this.BTN_100.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_100.Name = "BTN_100";
            this.BTN_100.Size = new System.Drawing.Size(158, 125);
            this.BTN_100.TabIndex = 5;
            this.BTN_100.Text = "$100";
            this.BTN_100.UseVisualStyleBackColor = false;
            this.BTN_100.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_50
            // 
            this.BTN_50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_50.FlatAppearance.BorderSize = 0;
            this.BTN_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_50.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.BTN_50.Location = new System.Drawing.Point(793, 235);
            this.BTN_50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_50.Name = "BTN_50";
            this.BTN_50.Size = new System.Drawing.Size(158, 125);
            this.BTN_50.TabIndex = 4;
            this.BTN_50.Text = "$50";
            this.BTN_50.UseVisualStyleBackColor = false;
            this.BTN_50.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_20
            // 
            this.BTN_20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_20.FlatAppearance.BorderSize = 0;
            this.BTN_20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_20.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_20.Location = new System.Drawing.Point(549, 235);
            this.BTN_20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_20.Name = "BTN_20";
            this.BTN_20.Size = new System.Drawing.Size(158, 125);
            this.BTN_20.TabIndex = 3;
            this.BTN_20.Text = "$20";
            this.BTN_20.UseVisualStyleBackColor = false;
            this.BTN_20.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_10
            // 
            this.BTN_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_10.FlatAppearance.BorderSize = 0;
            this.BTN_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_10.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.BTN_10.Location = new System.Drawing.Point(292, 235);
            this.BTN_10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_10.Name = "BTN_10";
            this.BTN_10.Size = new System.Drawing.Size(158, 125);
            this.BTN_10.TabIndex = 2;
            this.BTN_10.Text = "$10";
            this.BTN_10.UseVisualStyleBackColor = false;
            this.BTN_10.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL_MontoRecarga
            // 
            this.LBL_MontoRecarga.AutoSize = true;
            this.LBL_MontoRecarga.BackColor = System.Drawing.Color.Transparent;
            this.LBL_MontoRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_MontoRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MontoRecarga.Location = new System.Drawing.Point(497, 162);
            this.LBL_MontoRecarga.Name = "LBL_MontoRecarga";
            this.LBL_MontoRecarga.Size = new System.Drawing.Size(439, 29);
            this.LBL_MontoRecarga.TabIndex = 1;
            this.LBL_MontoRecarga.Text = "INGRESA LA CANTIDAD A RECARGAR";
            this.LBL_MontoRecarga.Click += new System.EventHandler(this.MontoRecarga_Click);
            // 
            // PIC_Fondo_Recharge
            // 
            this.PIC_Fondo_Recharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC_Fondo_Recharge.Image = global::ProyectoIntegrador.Properties.Resources.RECARGAS1;
            this.PIC_Fondo_Recharge.Location = new System.Drawing.Point(0, 0);
            this.PIC_Fondo_Recharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PIC_Fondo_Recharge.Name = "PIC_Fondo_Recharge";
            this.PIC_Fondo_Recharge.Size = new System.Drawing.Size(1440, 725);
            this.PIC_Fondo_Recharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Fondo_Recharge.TabIndex = 0;
            this.PIC_Fondo_Recharge.TabStop = false;
            this.PIC_Fondo_Recharge.Click += new System.EventHandler(this.Fondo_Recharge_Click);
            // 
            // Recharge_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 725);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Recharge_GUI";
            this.Text = "Recharge_GUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Fondo_Recharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PIC_Fondo_Recharge;
        private System.Windows.Forms.Button BNT_Recharge_Finish;
        private System.Windows.Forms.Label LBL_MontoRecarga;
        private System.Windows.Forms.Button BTN_100;
        private System.Windows.Forms.Button BTN_50;
        private System.Windows.Forms.Button BTN_20;
        private System.Windows.Forms.Button BTN_10;
    }
}