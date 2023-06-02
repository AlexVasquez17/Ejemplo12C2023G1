using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo12C2023G1
{
    public partial class frmMenùP : Form
    {
        public frmMenùP()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente frm = new frmPaciente();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenùP_Load(object sender, EventArgs e)
        {

        }
    }
}
