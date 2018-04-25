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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD = jose;USER=jose; ");
            ora.Open();
            MessageBox.Show("conectado");
            ora.Close();

            //String connectionString = "DATA SOURCE = (DESCRIPTION =" +
            //                          "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-IV8M3IR)(PORT = 1521))" +
            //                          "(CONNECT_DATA =" +
            //                          " (SERVER = DEDICATED)" +
            //                          "(SERVICE_NAME = XE)" +
            //                          ")" +
            //                          ");User Id = jose; password=jose;";

            //OracleConnection con = new OracleConnection();
            //con.ConnectionString = connectionString;

            //con.Open();

            //OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "select nombre from empleados where id_empleados=100";
            //cmd.Connection = con;

            //cmd.CommandType = CommandType.Text;

            //OracleDataReader dr = cmd.ExecuteReader();

            //dr.Read();
            //label1.Text = dr.GetString(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Splash frm = new Splash();
            frm.Close();

        }
    }
}
