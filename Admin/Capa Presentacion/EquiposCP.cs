using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Capa_Entidad;
namespace Capa_Presentacion
{
    public partial class EquiposCP : Form
    {
        public EquiposCP()
        {
            InitializeComponent();
        }

        private void InventarioCP_Load(object sender, EventArgs e)
        {

            EquipoCN equipoCN = new EquipoCN();
           
            dgvEquipos.DataSource = equipoCN.Listar();

            foreach (DataGridViewColumn columna in dgvEquipos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }
        private void BotRegesar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EquiposCP_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;

            EquipoCN equipoCN = new EquipoCN();

            dgvEquipos.DataSource = equipoCN.Listar();

            foreach (DataGridViewColumn columna in dgvEquipos.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                EquipoCE equipoCE = new EquipoCE();
                //equipoCE.Serie =
                equipoCE.Serie = txtSerie.Text;
                equipoCE.Marca = textMarca.Text;
                equipoCE.Modeloplaca = txtModeloPLaca.Text;
                equipoCE.Dislpay = txtDisplay.Text;
                equipoCE.Descripcion = txtDisplay.Text;
                equipoCE.Generacion = txtGeneracion.Text;
                equipoCE.Proviene = txtProviene.Text;
                equipoCE.Destino = txtDestino.Text;
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Elejiste eliminar");

            }
            else
            {
                MessageBox.Show("Elejiste nuevo");

            }

        }
    }
}
