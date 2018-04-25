using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace l4g
{
    public partial class REPORTEauditoriaMedicamentos : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD =jose;USER=jose; ");
        public REPORTEauditoriaMedicamentos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuReportes frm = new MenuReportes();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand cmd = new OracleCommand("selectmedicamentospornombre", ora);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("nom", OracleType.VarChar).Value = textBox1.Text;

            cmd.Parameters.Add("registromedicamentos", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            cmd.ExecuteNonQuery();
            ora.Close();
        }
    }
}
