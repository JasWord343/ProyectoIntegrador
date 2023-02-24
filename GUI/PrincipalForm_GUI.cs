using ProyectoIntegrador.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class PrincipalForm_GUI : Form
    {
        private Point LastPoint;
        public PrincipalForm_GUI()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EXTEND_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PIC_Maximize.Visible = false;
            Restore.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restore.Visible = false;
            PIC_Maximize.Visible = true;
        }

        private void MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Recharge//
        private void BTN_Recharge_Click(object sender, EventArgs e)
        {
            OpenFormRecharge(new Recharge_GUI());
        }
        private void OpenFormRecharge(object formrecarga)
        {
            if (this.PNL_Panel_Contenedor.Controls.Count > 0)

                this.PNL_Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formrecarga as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PNL_Panel_Contenedor.Controls.Add(fh);
            this.PNL_Panel_Contenedor.Tag = fh;
            fh.Show();
        }
        //fin//
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormUserManage(new UserManagment_GUI());

        }
        private void OpenFormUserManage(object formrusuario)
        {
            if (this.PNL_Panel_Contenedor.Controls.Count > 0)

                this.PNL_Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formrusuario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PNL_Panel_Contenedor.Controls.Add(fh);
            this.PNL_Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void PrincipalForm_GUI_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void PrincipalForm_GUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void PNL_TOP_PRINCIPAL_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void PNL_TOP_PRINCIPAL_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void PIC_FONDO_WELCOME_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void PIC_FONDO_WELCOME_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}