using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;

namespace l4g
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
            
            /*  int id = Convert.ToInt32(txt_i_PK_Id.Text);
            string descripcion = txt_vc_DescripcionProducto.Text;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int idcitas = Convert.ToInt32(textBox1);
            //int iddoc = Convert.ToInt32(textBox2);
            //int idem = Convert.ToInt32(textBox3);
            //int fecha = Convert.ToInt32(textBox4);
            //string ob = textBox5.Text;

            //String connectionString = "DATA SOURCE = (DESCRIPTION =" +
            //                         "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-IV8M3IR)(PORT = 1521))" +
            //                         "(CONNECT_DATA =" +
            //                         " (SERVER = DEDICATED)" +
            //                         "(SERVICE_NAME = XE)" +
            //                         ")" +
            //                         ");User Id = jose; password=jose;";

            //OracleConnection con = new OracleConnection();
            //con.ConnectionString = connectionString;

            //con.Open();

            //OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "insert into citas (id_citas,id_doctor,id_empleado,fecha,observacion) values ('"+textBox1+"','"+textBox2+"','"+textBox3+"',to_date('"+textBox4+"','dd,mm,yyyy'),'"+textBox5+"');";
            //cmd.Connection = con;
        }
    }
}
