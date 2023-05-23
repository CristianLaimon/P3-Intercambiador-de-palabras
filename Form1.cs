using System.Diagnostics;

namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Form1 : Form
    {
        private static Form1 instancia;
        private StreamWriter escritor;
        private FileStream flujo;
        private StreamReader lector;
        private string nombreArchivo, rutaArchivo, rutaProyecto;
        private bool alreadyModified;

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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonReemplazar_Click(object sender, EventArgs e)
        {
            Reemplazar();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSeleccionarArchivo_Click(object sender, EventArgs e) => SeleccionarFile();

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

            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Originales");
            saveFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Modificados");
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Archivos de Text (*.txt)|*.txt";
            toolStripStatusLabel1.Text = "Hecho por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
            textBoxInput.Enabled = false;
            textBoxOutput.Enabled = false;
        }

        private void Reemplazar()
        {
            if (textBoxInput.Text != "" && textBoxOutput.Text != null)
            {
                string rutaArchivoTemporal = Path.Combine(RutaProyecto, "temp", NombreArchivo);
                string input = textBoxInput.Text;
                string output = textBoxOutput.Text;
                string texto;

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

                File.Copy(RutaArchivo, rutaArchivoTemporal, true); //Se realiza una copia del archivo original

                File.WriteAllText(rutaArchivoTemporal, textoModificado); //Se sobreescribe el contenido del archivo temporal.

                using (FileStream flujoTemporal = new FileStream(rutaArchivoTemporal, FileMode.Open, FileAccess.ReadWrite)) //Se muestra el contenido recien cambiado del archivo temporal usando otro filestream (el segundo) temporalemnte
                {
                    StreamReader lectorTemporal = new StreamReader(flujoTemporal);
                    richTextBoxModificado.Text = lectorTemporal.ReadToEnd();
                    lectorTemporal.Close();
                }

                int indiceInicial = 0;
                int contador = 0;
                int indiceEncontrado = 0;

                while ((indiceEncontrado = texto.IndexOf(input, indiceInicial)) != -1) 
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Application.StartupPath, "temp"));
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void textBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Reemplazar();
            }
        }
    }
}