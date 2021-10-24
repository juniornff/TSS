using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.Model;

namespace TSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.WSProcesoAutoDeterminacion info = new localhost.WSProcesoAutoDeterminacion();
            
            dataGridView1.DataSource = info.GetEncabezados();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.DataSource = info.GetDetalles();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encabezado encabezado = new Encabezado();
            List<Detalle> detalles = new List<Detalle>();
            localhost.WSProcesoAutoDeterminacion info = new localhost.WSProcesoAutoDeterminacion();


        }
    }
}
