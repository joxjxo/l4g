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
    public partial class inventario : Form
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD =jose;USER=jose; ");
        public inventario()
        {
            InitializeComponent();
            #region 
            ora.Open();
            OracleCommand cmd = new OracleCommand("selectemedicamentos", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registromedicamentos", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            ora.Close();
            #endregion


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                /*ID_MED ,DESCP ,PRESENTA ,CAT ,MAR ,PRE ,PRO ,UNI, CANTIUNI,FECHCOM,FECHIN,FECHVEN*/
                ora.Open();
                OracleCommand comando = new OracleCommand("insertmedicamentos", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("ID_MED", OracleType.Number).Value = txtid.Text;
                comando.Parameters.Add("DESCP", OracleType.VarChar).Value = txtdes.Text;
                comando.Parameters.Add("PRESENTA", OracleType.VarChar).Value = txtpresentacion.Text;
                comando.Parameters.Add("CAT", OracleType.VarChar).Value = txtcat.Text;
                comando.Parameters.Add("MAR", OracleType.VarChar).Value = txtmarca.Text;
                comando.Parameters.Add("PRE", OracleType.Number).Value = txtprecio.Text;
                comando.Parameters.Add("PRO", OracleType.VarChar).Value = txtprovedor.Text;
                comando.Parameters.Add("UNI", OracleType.VarChar).Value = txtunidadmedida.Text;
                comando.Parameters.Add("CANTIUNI", OracleType.VarChar).Value = txtcantidadunitaria.Text;
                comando.Parameters.Add("FECHCOM", OracleType.DateTime).Value = dtpFECHACOMPRA.Text;
                comando.Parameters.Add("FECHIN", OracleType.DateTime).Value = dtpFECHAINGRESO.Text;
                comando.Parameters.Add("FECHVEN", OracleType.DateTime).Value = dtpFECHAVENCIMIENTO.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("MEDICAMENTO insertado");
            }
            catch (Exception)
            {

                MessageBox.Show("error al insertar");
            }

            ora.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frmi = new Menu();
            frmi.Show();

        }

        private void inventario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
