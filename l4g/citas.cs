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
    public partial class citas : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD = jose;USER=jose; ");
        public citas()
        {
            InitializeComponent();
            #region cb1
            string query = "select ID_DOCTORES from DOCTORES";

            OracleCommand cmddatabase = new OracleCommand(query, ora);

            try
            {
                ora.Open();
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                myReader = cmddatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetInt32(0).ToString();
                    cb1.Items.Add(sname.ToString());
                }
                ora.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region cb2
            string query2 = "select ID_EMPLEADOS from EMPLEADOS";

            OracleCommand cmddatabase2 = new OracleCommand(query2, ora);

            try
            {
                ora.Open();
                OracleDataReader myReader = cmddatabase2.ExecuteReader(); ;
                myReader = cmddatabase2.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetInt32(0).ToString();
                    cb2.Items.Add(sname.ToString());
                }
                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

        }



        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand cmd = new OracleCommand("selectcitasdehoy", ora);
            
            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("fech", OracleType.DateTime).Value = dtp1.Text;
            
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            cmd.ExecuteNonQuery();
            ora.Close();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {

            try
            {
                /*iddc,ide,fech,obs*/
                ora.Open();
                OracleCommand comando = new OracleCommand("insertecitas", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("iddc", OracleType.Number).Value = Convert.ToInt32(cb1.SelectedItem);
                comando.Parameters.Add("ide", OracleType.Number).Value = Convert.ToInt32(cb2.SelectedItem);
                comando.Parameters.Add("fech", OracleType.DateTime).Value = dtpcitas.Text;
                comando.Parameters.Add("obs", OracleType.VarChar).Value = txtobservaciones.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("empleado insertado");
            }
            catch (Exception)
            {

                MessageBox.Show("error al insertar");
            }
            ora.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("selectcitas", ora);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            ora.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void citas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frmi = new Menu();
            frmi.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu frmi = new Menu();
            frmi.Show();
        }
    }
    }

