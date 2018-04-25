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
   
    public partial class selcetprueba : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD = jose;USER=jose; ");
        public selcetprueba()
        {
            InitializeComponent();
            ora.Open();
            OracleCommand cmd = new OracleCommand("selectempleados", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registrosempleados", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            ora.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ora.Open();
            //OracleCommand cmd = new OracleCommand("selectcitas",ora);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            //OracleDataAdapter adaptador = new OracleDataAdapter();
            //adaptador.SelectCommand = cmd;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
            //ora.Close();
        }
    }
}
