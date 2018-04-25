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
    public partial class Menu : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD = jose;USER=jose; ");
        public Menu()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Today;
            string fecha2 = Convert.ToString(fecha);

            ora.Open();
            OracleCommand cmd = new OracleCommand("selectcitasdehoy", ora);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("fech", OracleType.DateTime).Value = fecha2;

            cmd.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            cmd.ExecuteNonQuery();
            ora.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            citas frm = new citas();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            selcetprueba frms = new selcetprueba();
            frms.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            insesrtempleados frmi = new insesrtempleados();
            frmi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventario frmi = new inventario();
            frmi.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CONSULTA frm = new CONSULTA();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuReportes frm = new MenuReportes();
            frm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            insesrtempleados frm = new insesrtempleados();
            frm.Show();

        }
    }
}
