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
        private string rutaaGuardar;
        public Guardar()
        {
            InitializeComponent();
            
        }

        private void Guardar_Load(object sender, EventArgs e)
        {
            buttonGuardar.Focus();
            this.MaximizeBox = false;
            saveFileDialog1.Filter = "Archivos de Texto(*.txt)|*.txt";
            buttonGuardar.Enabled = false;
            rutaaGuardar = Path.Combine(Application.StartupPath, "Modificados");
            textBoxRutaNueva.Text = rutaaGuardar;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Form1.Instancia.Enabled = true; //Para esto es la property del Form1.
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1.Instancia.Enabled = true; //Para esto es la property del Form1.
            this.Close();
        }

        private void Guardar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Instancia.Enabled = true;
            if (textBoxNewName.Text != "")
            {
                File.Copy(Path.Combine(Application.StartupPath, "temp", Form1.Instancia.NombreArchivo), textBoxRutaNueva.Text.Replace(Path.GetFileName(saveFileDialog1.FileName), textBoxNewName.Text) + ".txt", true);
            }
            else
            {
                File.Copy(Path.Combine(Application.StartupPath, "temp", Form1.Instancia.NombreArchivo), textBoxRutaNueva.Text + "Modificado:D.txt", true);
            }
        }

        private void buttonSeleccionarDirectorio_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaaGuardar = saveFileDialog1.FileName;
                textBoxRutaNueva.Text = rutaaGuardar;
                openFileDialog1.FileName = textBoxNewName.Text;
            }
            buttonGuardar.Enabled = true;
        }
    }
}
