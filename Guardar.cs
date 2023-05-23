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
        private static Guardar instancia;
        public Guardar()
        {
            InitializeComponent();
        }

        public static Guardar Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Guardar();
                }
                return instancia;
            }
        }

        private void Guardar_Load(object sender, EventArgs e)
        {
            buttonGuardar.Focus();
            this.MaximizeBox = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instancia.Enabled = true;
        }
    }
}
