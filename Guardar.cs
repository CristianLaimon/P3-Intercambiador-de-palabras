using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Guardar : Form
    {
        public Guardar()
        {
            InitializeComponent();

        }

        private void Guardar_Load(object sender, EventArgs e)
        {
            buttonGuardar.Focus();
            this.MaximizeBox = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Form1.Instancia.Enabled = true;
            this.Close();
        }
    }
}
