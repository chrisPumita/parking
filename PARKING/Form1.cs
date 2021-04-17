using PARKING.CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CONEXION con = CONEXION.getInstance;
             MessageBox.Show("Conexion " + (con.VerifyConnection()?"establecida": "fallida"));
             lblConexion.Text = "Conectado a : " + Properties.Settings.Default.host;
        }

    }
}
