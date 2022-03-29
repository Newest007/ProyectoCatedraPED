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
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            indicator.Top = btnMaterias.Top + 10;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {

            indicator.Top = btnAlumnos.Top + 10;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

            indicator.Top = btnDocentes.Top + 10;
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {

            indicator.Top = btnAulas.Top + 10;
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {

            indicator.Top = btnNotas.Top + 10;
        }
    }
}
