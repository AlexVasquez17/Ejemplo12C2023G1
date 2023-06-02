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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void especialidadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.especialidadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.especialidad' Puede moverla o quitarla según sea necesario.
            this.especialidadTableAdapter.Fill(this.database1DataSet.especialidad);

        }
    }
}
