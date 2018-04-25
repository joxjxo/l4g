using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace l4g.clases
{
    class comboboxdoctores
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = DESKTOP-IV8M3IR; PASSWORD =jose;USER=jose; ");

        public void seleccionarDoctroes(ComboBox cb)
        {
            cb.Items.Clear();
            ora.Open();
            OracleCommand cmd = new OracleCommand("select * from DOCTORES", ora);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }

            ora.Close();
            cb.Items.Insert(0, "seleccione un doctor");
            cb.SelectedIndex = 0;

        }
    }

}