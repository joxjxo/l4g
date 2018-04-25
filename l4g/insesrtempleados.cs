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
    public partial class insesrtempleados : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD =jose;USER=jose; ");
        public insesrtempleados()
        {
            InitializeComponent();
            cbbgenero.Items.Add("masculino");
            cbbgenero.Items.Add("femenino");
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
           

            string genero = cbbgenero.SelectedItem.ToString();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("insertempleados", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtnombre.Text;
                comando.Parameters.Add("apell1", OracleType.VarChar).Value = txtapell1.Text;
                comando.Parameters.Add("apell2", OracleType.VarChar).Value = txtapell2.Text;
                comando.Parameters.Add("ed", OracleType.Number).Value = txtedad.Text;
                comando.Parameters.Add("pes", OracleType.Number).Value = txtpeso.Text;
                comando.Parameters.Add("gen", OracleType.VarChar).Value = genero;
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

            //ora.Open();
            //OracleCommand cmd = new OracleCommand("selectempleados", ora);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("registrosempleados", OracleType.Cursor).Direction = ParameterDirection.Output;

            //OracleDataAdapter adaptador = new OracleDataAdapter();
            //adaptador.SelectCommand = cmd;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
            //ora.Close();
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            string genero = cbbgenero.SelectedItem.ToString();
            ora.Open();
            OracleCommand comando = new OracleCommand("actualizarempleados", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("id_em", OracleType.Number).Value = Convert.ToInt32(TXTIDAC.Text);
            comando.Parameters.Add("nom", OracleType.VarChar).Value = txtnombre.Text;
            comando.Parameters.Add("apell1", OracleType.VarChar).Value = txtapell1.Text;
            comando.Parameters.Add("apell2", OracleType.VarChar).Value = txtapell2.Text;
            comando.Parameters.Add("ed", OracleType.Number).Value = txtedad.Text;
            comando.Parameters.Add("pes", OracleType.Number).Value = txtpeso.Text;
            comando.Parameters.Add("gen", OracleType.VarChar).Value = genero;
            comando.ExecuteNonQuery();
            MessageBox.Show("empleado actualizado");
            ora.Close();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("eliminarempleado", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ide", OracleType.Number).Value = Convert.ToInt32(txtiddelete.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("empleado eliminado");
            ora.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTIDAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu frm = new Menu();
            frm.Show();

        }
    }
}
