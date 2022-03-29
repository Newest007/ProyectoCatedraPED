using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Cátedra_PED
{
    public partial class CargarDatos : Form
    {
        Usuario usuari;

        public CargarDatos()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {
            //Guardando los usuarios por defecto - Con encriptacion SHA512
            usuari = new Usuario();

            //Alumno - alumnoudb
            usuari.ListaUsuarios.Add(new Usuario("alumno", "8F92E373658FE73B2804568ABEA32260A2255343CFEB6B625161C790C98C297E07719FC726D68920F4591E46FB0BBDB029BEC5FDA062AD570D76C6969D9CD95D"));

            //Director - directorudb
            usuari.ListaUsuarios.Add(new Usuario("director", "78AFACA57859EFA88F74A8141AC436DD5F3F16178A6C2D167024DB3F67E4892D3D905A2DA0F0D5F4B0228C6BD6E6092EE392E62488FC8E2C9F41DF1684BD9111"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
