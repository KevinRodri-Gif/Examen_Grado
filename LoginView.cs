using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DegreeExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1iniciosesion_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("server=DESKTOP-RCFOEPO\\SQLEXPRESS; database=Sistema; integrated security=true");

            conexion.Open();
            string consulta = "select nombre,clave from usuario where nombre='"+TextBotLoginEmail.Text+ "'and clave='"+textBox2password.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registro = comando.ExecuteReader();
          
            if (registro.Read())
            {

                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2password_ParentChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
