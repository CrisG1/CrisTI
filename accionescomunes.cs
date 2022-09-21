using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Codigo
{
    public class AccionesComunes
    {
        public static void mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void llenarCombo(string consulta, ComboBox combo, string id, string campo)
        {
            DataTable dt;
            dt = Conexion.EjecutaSeleccion(consulta);
            if (dt == null)
            {
                return;
            }
            DataRow nuevaFila = dt.NewRow();
            nuevaFila[id] = 0;
            nuevaFila[campo] = "TODOS";
            dt.Rows.InsertAt(nuevaFila, 0);
            combo.DataSource = dt;
            combo.ValueMember = id;
            combo.DisplayMember = campo;
        }
    }
}
