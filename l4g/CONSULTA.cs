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
    public partial class CONSULTA : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD =jose;USER=jose; ");
        public CONSULTA()
        {
            #region
            InitializeComponent();
            ora.Open();
            OracleCommand cmd = new OracleCommand("medicamentos_id_nombre", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registromedicamentos", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            ddtmedi.DataSource = tabla;
            ora.Close();
            #endregion

            #region
            string query = "select ID_MEDICAMENTO from INVENTARIO_MEDICO";

            OracleCommand cmddatabase = new OracleCommand(query, ora);

            try
            {
                ora.Open();
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                myReader = cmddatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetInt32(0).ToString();
                    cbmediapi.Items.Add(sname.ToString());
                }
                ora.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region 
            string query2 = "select ID_CITAS from CITAS";

            OracleCommand cmddatabase2 = new OracleCommand(query2, ora);

            try
            {
                ora.Open();
                OracleDataReader myReader = cmddatabase2.ExecuteReader(); ;
                myReader = cmddatabase2.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetInt32(0).ToString();
                    cbb_citaid.Items.Add(sname.ToString());
                }

                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region
            string query3 = "select ID_DOCTORES from DOCTORES";

            OracleCommand cmddatabase3 = new OracleCommand(query3, ora);

            try
            {
                ora.Open();
                OracleDataReader myReader = cmddatabase3.ExecuteReader(); ;
                myReader = cmddatabase3.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetInt32(0).ToString();
                    CBBDOCTORES.Items.Add(sname.ToString());
                }

                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region
            string query4 = "select ID_EMPLEADOS from EMPLEADOS";

            OracleCommand cmddatabase4 = new OracleCommand(query4, ora);

            try
            {
                ora.Open();
                OracleDataReader myReader = cmddatabase4.ExecuteReader(); ;
                myReader = cmddatabase4.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetInt32(0).ToString();
                    CBBEMPLEADOS.Items.Add(sname.ToString());
                }

                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void btn_insertar_apmed_Click(object sender, EventArgs e)
        {

            try
            {
                /*idp,idm,fech,mot,dosis,idmedi*/
                ora.Open();
                OracleCommand comando1 = new OracleCommand("insertAPLICACIONMEDICAMENTO", ora);
                comando1.CommandType = System.Data.CommandType.StoredProcedure;
                comando1.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(CBBEMPLEADOS.SelectedItem);
                comando1.Parameters.Add("idm", OracleType.Number).Value = Convert.ToInt32(cbmediapi.SelectedItem);
                comando1.Parameters.Add("fech", OracleType.DateTime).Value = Convert.ToDateTime(dtpaplicacion.Text);
                comando1.Parameters.Add("mot", OracleType.VarChar).Value = txtmotivo.Text;
                comando1.Parameters.Add("dosis", OracleType.VarChar).Value = txtdosisaplicada.Text;
                

                comando1.ExecuteNonQuery();
                MessageBox.Show("insertado");
                ora.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("error al insertar");
            }

            

            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTEXPM", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idemp", OracleType.Number).Value = Convert.ToInt32(CBBEMPLEADOS.SelectedItem);
                comando.Parameters.Add("idci", OracleType.Number).Value = Convert.ToInt32(cbb_citaid.SelectedItem);


                comando.ExecuteNonQuery();
                ora.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("error al insertar EXP");
            }
                

            

            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*iddc,ide,descr,diag*/
                ora.Open();
                OracleCommand comando = new OracleCommand("insertdiagnostico", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("iddc", OracleType.Number).Value = Convert.ToInt32(CBBDOCTORES.SelectedItem);
                comando.Parameters.Add("ide", OracleType.Number).Value = Convert.ToInt32(CBBEMPLEADOS.SelectedItem);
                comando.Parameters.Add("descr", OracleType.VarChar).Value = txtdes.Text;
                comando.Parameters.Add("diag", OracleType.VarChar).Value = txtdiag.Text;
                
                comando.ExecuteNonQuery();
                MessageBox.Show("diagnostico insertado insertado");
            }
            catch (Exception)
            {

                MessageBox.Show("error al insertar");
            }

            ora.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.Show();
        }
    }
}
