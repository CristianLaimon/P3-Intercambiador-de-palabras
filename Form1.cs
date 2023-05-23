using System.Diagnostics;

namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Form1 : Form
    {
        private static Form1 instancia;
        private bool alreadyModified;
        private StreamWriter escritor;
        private FileStream flujo;
        private StreamReader lector;
        private string nombreArchivo, rutaArchivo, rutaProyecto;

        public Form1()
        {
            InitializeComponent();
        }

        public string NombreArchivo { get => nombreArchivo; set => nombreArchivo = value; }
        public string RutaArchivo { get => rutaArchivo; set => rutaArchivo = value; }
        public string RutaProyecto { get => rutaProyecto; set => rutaProyecto = value; }

        private void AbrirFlujo(string ruta, FileMode fileMode, FileAccess fileAccess)
        {
            if (flujo != null)
            {
                escritor.Close();
                lector.Close();
                flujo.Close();
            }

            flujo = new FileStream(ruta, fileMode, fileAccess);
            escritor = new StreamWriter(flujo);
            lector = new StreamReader(flujo);
        }

        private void abrirModificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp"));
        }

        private void buttonReemplazar_Click(object sender, EventArgs e)
        {
            Reemplazar();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (flujo != null)
            {
            escritor.Close();
            lector.Close();
            flujo.Close();
            }
            Application.Exit();
        }

        private void buttonSeleccionarArchivo_Click(object sender, EventArgs e) => SeleccionarFile();

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flujo != null)
            {
                escritor.Close();
                lector.Close();
                flujo.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "Modificados"))) //Se crean manualmente debido a que visual no permite copiar carpetas vacías, y estás lo estarán.
            {
                Directory.CreateDirectory("Modificados");
            }

            if (!File.Exists(Path.Combine(Application.StartupPath, "Temp")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "temp"));
            }

            if (!File.Exists(Path.Combine(Application.StartupPath, "Temp2")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "temp2"));
            }

            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Originales");
            saveFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Modificados");
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Archivos de Text (*.txt)|*.txt";
            toolStripStatusLabel1.Text = "Hecho por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
            textBoxInput.Enabled = false;
            textBoxOutput.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp"));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp"));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            IntercambiarInputs();
        }

        private void Reemplazar()
        {
            if (textBoxInput.Text != "" && textBoxOutput.Text != null)
            {
                string input = textBoxInput.Text.Trim();
                string output = textBoxOutput.Text.Trim();
                string texto, rutaArchivoTemporal;

                if (alreadyModified == false)
                {
                    texto = richTextBoxOriginal.Text;
                    alreadyModified = true;
                }
                else
                {
                    texto = richTextBoxModificado.Text;
                }

                string textoModificado = texto.Replace(input, output, StringComparison.OrdinalIgnoreCase); //Se creo una copia y se modifico, falta sobreescribir el archivo con este nuevo contenido.

                if (checkBox1.Checked)
                {
                    rutaArchivoTemporal = Path.Combine(RutaProyecto, "temp", Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "modificado.txt");
                }
                else
                {
                    rutaArchivoTemporal = Path.Combine(RutaProyecto, "temp2", Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "notModified.txt");
                }

                File.Copy(RutaArchivo, rutaArchivoTemporal, true); //Se realiza una copia del archivo original

                File.WriteAllText(rutaArchivoTemporal, textoModificado); //Se sobreescribe el contenido del archivo temporal.

                using (FileStream flujoTemporal = new FileStream(rutaArchivoTemporal, FileMode.Open, FileAccess.ReadWrite)) //Se muestra el contenido recien cambiado del archivo temporal usando otro filestream (el segundo) temporalemnte
                {
                    StreamReader lectorTemporal = new StreamReader(flujoTemporal);
                    richTextBoxModificado.Text = lectorTemporal.ReadToEnd();
                    lectorTemporal.Close();
                }

                string inputUpper = input.ToUpper().Trim();
                string textoUpper = texto.ToUpper();
                int indiceInicial = 0;
                int contador = 0;
                int indiceEncontrado = 0;

                while ((indiceEncontrado = textoUpper.IndexOf(inputUpper, indiceInicial)) != -1)
                {
                    contador++;
                    indiceInicial = indiceEncontrado + input.Length;
                }

                labelNoRemplazos.Text = "No. de Reemplazos: " + contador;
            }
            else
            {
                MessageBox.Show("No ha ingresado nada en los campos reemplazar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SeleccionarFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                alreadyModified = false;
                RutaArchivo = openFileDialog1.FileName;
                NombreArchivo = Path.GetFileName(openFileDialog1.FileName);
                RutaProyecto = Application.StartupPath;
                labelNombreArchivoOriginal.Text = Path.GetFileName(RutaArchivo);
                toolStripStatusLabel1.Text = RutaArchivo;

                AbrirFlujo(RutaArchivo, FileMode.Open, FileAccess.ReadWrite);

                richTextBoxOriginal.Text = lector.ReadToEnd();
                flujo.Seek(0, SeekOrigin.Begin);
                richTextBoxModificado.Text = lector.ReadToEnd();
                flujo.Seek(0, SeekOrigin.Begin);

                textBoxOutput.Enabled = true;
                textBoxInput.Enabled = true;
                buttonReemplazar.Enabled = true;
            }
        }

        private void seleccionarNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e) => SeleccionarFile();

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp2"));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp"));
        }

        private void abrirLosOtrosModificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp"));
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Reemplazar();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            textBoxInput.Focus();
        }

        private void IntercambiarInputs()
        {
            string tempInput = textBoxInput.Text.Trim();
            textBoxInput.Text = textBoxOutput.Text.Trim();
            textBoxOutput.Text = tempInput;
        }

        private void textBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Reemplazar();
            }
        }
    }
}