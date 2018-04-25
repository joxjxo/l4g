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
    public partial class pruebas : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD = jose;USER=jose; ");
        public pruebas()
        {
            InitializeComponent();
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
                    cb.Items.Add(sname.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pruebas_Load(object sender, EventArgs e)
        {

        }
    }
}
