using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Proyecto_de_Cátedra_PED
{
    public partial class FormLogin : Form
    {
        Usuario usuari;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            usuari = new Usuario();
        }
        //================================================================//
        //       Funcion para encriptar la contraseña ingresada           //
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
        //================================================================//

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtContraseña.Text;

            bool login = false;

            if (usuario.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Por favor rellena todos los campos.");
            }
            else
            {
                //Encriptando la contra SHA512
                string passSha512 = ComputeHash(pass, new SHA512CryptoServiceProvider());
                passSha512 = passSha512.Replace("-", "");//Se quitan los guiones de la contraseña encriptada
                //Porque nos devolvia : ' 7F-CF-4B-A3-91- ....... ' 

                foreach (var x in usuari.ListaUsuarios)
                {
                    if (x.User.Equals(usuario) && x.Contra.Equals(passSha512))
                    {

                        login = true;
                        this.Hide();

                        Form1 formPrincipal = new Form1();

                        
                        if (txtUsuario.Text == "alumno")
                        {
                            formPrincipal.btnAlumnos.Visible = false;
                        }

                        formPrincipal.usuarioActivo = x.User;
                        formPrincipal.label4.Text = x.User;
                        formPrincipal.Show();

                    }
                }

                if (login == false)
                {
                    MessageBox.Show(" Credenciales incorrectas ");
                }

            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text =="Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }


        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
