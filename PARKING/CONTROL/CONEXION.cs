using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING.CONTROL
{
    class CONEXION
    {
        private static CONEXION instance = null;


        static string ip = "localhost";
        static string puerto = "3306";
        static string userBD = "root";
        static string pw = "";
        static string DataBaseName = "sanson";

        MySqlConnection cn;

        public MySqlConnection Cn
        {
            get { return cn; }
            set { cn = value; }
        }

        protected CONEXION()
        {
            try
            {
                //Link del enlace con MySQL
                string link = "datasource=" + ip + ";port=" + puerto + ";username=" + userBD + ";Password=" + pw + ";database=" + DataBaseName + ";";
                cn = new MySqlConnection(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexion fallo, se ha perdido la conexion a internet: error reportado " + ex.ToString());
            }
        }

        public static CONEXION getInstance
        {
            get
            {
                if (instance == null)
                    //Vamos a crear el objeto de conexion disponible para las demas clases
                    instance = new CONEXION();
                return instance;
            }
        }

        /// <summary>
        /// verifica la conexion a la base de datos
        /// </summary>
        /// <returns></returns>
        public bool VerifyConnection()
        {
            try
            {
                cn.Open();
                cn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
