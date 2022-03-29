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
    public partial class Form1 : Form
    {

        public String usuarioActivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMaterias>();
            indicator.Top = btnMaterias.Top + 10;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAlumnos>();
            indicator.Top = btnAlumnos.Top + 10;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDocentes>();
            indicator.Top = btnDocentes.Top + 10;
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAulas>();
            indicator.Top = btnAulas.Top + 10;
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormNotas>();
            indicator.Top = btnNotas.Top + 10;
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlAbrirForm.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlAbrirForm.Controls.Add(formulario);
                pnlAbrirForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sea bienvenido al programa " + usuarioActivo + "!","Hola!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pnlAbrirForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
