using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BotIngresar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    PlantillaCN plantillaCN = new PlantillaCN();
                    var valdLogin = plantillaCN.Login(txtUsuario.Text, txtContraseña.Text);
                    if (valdLogin == true)
                    {
                        MenuPrincipal menuad = new MenuPrincipal();
                        menuad.Show();
                        menuad.FormClosed +=Logout ;
                        menuad.WindowState = FormWindowState.Maximized;
                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña erronea");

                        txtUsuario.Focus();
                        txtContraseña.Clear();

                    }

                }

            }


        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cerra una ventana
            DialogResult rpta = MessageBox.Show("¿Esta seguro que desea salir del sistema?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (rpta == DialogResult.Yes)
            {
                //No cancelamos el cerrado
                e.Cancel = false;
            }
            else
            {
                //Se cancela el cierre
                e.Cancel = true;
            }   
        }
    }
}


