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
    public partial class expedientemedico : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD =jose;USER=jose; ");
        public expedientemedico()
        {
            InitializeComponent();
        }

        private void expedientemedico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand cmd = new OracleCommand("selectEMPELADO", ora);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ide", OracleType.Number).Value = txtidempleado.Text;

            cmd.Parameters.Add("registrosemp", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            cmd.ExecuteNonQuery();
            ora.Close();
            txtidempleado.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtidempleado.ReadOnly = false;
        }
    }
}
