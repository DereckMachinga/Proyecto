using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class MenuPrincipal : Form
    {
        private EquiposCP inventarioCP;
        public MenuPrincipal()
        {
            InitializeComponent();
        }



        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.WindowState = FormWindowState.Maximized;
            this.Show();
           
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cerra una ventana
            DialogResult rpta = MessageBox.Show("¿Esta seguro que deseas cerrar sesión?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void OperacionInventario_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void OperacionInventario_Click(object sender, EventArgs e)
        {
            inventarioCP = new EquiposCP();
            inventarioCP.MdiParent = this;
            inventarioCP.WindowState = FormWindowState.Maximized;
            inventarioCP.MaximizeBox = false;
            inventarioCP.MinimizeBox = false;
            inventarioCP.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }
    }
}
