using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoIntegrador.GUI
{
    public partial class Login_GUI : Form
    {
        public Login_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalForm_GUI login = new PrincipalForm_GUI();
            this.Hide();

            {
                string username = TXT_USER.Text;
                string password = TXT_PASSWORD.Text;

                if (username == "ADMIN" && password == "201100")
                {
                    MessageBox.Show("Acceso Concedido, Bienvenido");
                    Form formLogin = new PrincipalForm_GUI();
                    formLogin.Show();

                }
                else
                {
                    MessageBox.Show("NEL PERRO");
                    this.Close();

                }

            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PASSWORD_Click(object sender, EventArgs e)
        {

        }
    }
}
