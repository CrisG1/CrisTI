using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int registrosafectados = 0;
            registrosafectados = Conexion.EjecutaConsulta(textBox1.Text);
            AccionesComunes.mensaje("Registros Afectados: " + registrosafectados);
            AccionesComunes.llenarCombo(textBox1.Text, comboBox1, "id_Cliente", "Articulo");
            AccionesComunes.llenagrid(textBox1.Text, dataGridView1);
            AccionesComunes.llenalistview(textBox1.Text, listView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
