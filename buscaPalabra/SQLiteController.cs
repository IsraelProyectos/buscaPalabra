using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;


namespace buscaPalabra
{
    class SQLiteController
    {
        ControlPermutaciones cp = new ControlPermutaciones();
        public bool accesoBD(string query, string palabra)
        {
            try
            {

            
            SQLiteConnection con = new SQLiteConnection("Data Source=misDatabases.bd");
            con.Open();

            if (query == "Select")
            {


                SQLiteParameter param = new SQLiteParameter();
                //param.Value = query;
                string cmdStr = "SELECT COUNT(*) FROM Dictionary where Words = '" + palabra + "';";
                SQLiteCommand cmd = new SQLiteCommand(cmdStr, con);
                //cmd.Parameters.Add(param);
                cmd.Parameters.AddWithValue("Id", palabra);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
