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
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "empleado" && txtContraseña.Text == "789")
            {
                MessageBox.Show("bienvenido", "laosCorporation");
                this.Hide();
                frmMenùP frm = new frmMenùP();
                frm.Show();
                txtNombre.BackColor = Color.White;
                txtContraseña.BackColor = Color.WhiteSmoke;
            }
            else
            {
                MessageBox.Show("Nombre y Contraseña incorrectos", "laosCorporation");
                txtNombre.Text = "";
                txtContraseña.Text = "";
                txtNombre.Focus();
                txtNombre.BackColor = Color.Aquamarine;
                txtContraseña.BackColor = Color.Beige;


            }
        }
    }
}
