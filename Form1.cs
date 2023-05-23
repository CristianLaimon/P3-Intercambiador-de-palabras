using System.Runtime.InteropServices.ComTypes;

namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Form1 : Form
    {
        private static Form1 instancia;
        private StreamWriter escritor;
        private FileStream flujo;
        private StreamReader lector;
        private string nombreArchivo, rutaArchivo, rutaProyecto;


        //private char[] textoChar, inputChar, outputChar;
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = (Form1)Application.OpenForms[0];
                }
                return instancia;
            }
        }

        private void AbrirFlujo(string ruta, FileMode fileMode, FileAccess fileAccess)
        {
            if (flujo != null)
            {
                flujo.Close();
                lector.Close();
                escritor.Close();
            }

            flujo = new FileStream(ruta, fileMode, fileAccess);
            escritor = new StreamWriter(flujo);
            lector = new StreamReader(flujo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var guardarForm = new Guardar();
            guardarForm.Show();
            guardarForm.BringToFront();
            this.Enabled = false;
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
            toolStripStatusLabel1.Text = "Hecho por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
            textBoxInput.Enabled = false;
            textBoxOutput.Enabled = false;
        }

        private void Reemplazar()
        {
            string rutaArchivoTemporal = Path.Combine(rutaProyecto, "temp", nombreArchivo);
            string input = textBoxInput.Text;
            string output = textBoxOutput.Text;
            string texto = richTextBoxOriginal.Text;
            string textoModificado = texto.Replace(input, output); //Se creo una copia y se modifico, falta sobreescribir el archivo con este nuevo contenido.

            File.Copy(rutaArchivo, rutaArchivoTemporal, true); //Se realiza una copia del archivo original

            File.WriteAllText(rutaArchivoTemporal, textoModificado); //Se sobreescribe el contenido del archivo temporal.

            using (FileStream flujoTemporal = new FileStream(rutaArchivo, FileMode.Open, FileAccess.ReadWrite)) //Se muestra el contenido recien cambiado del archivo temporal usando otro filestream (el segundo) temporalemnte
            {
                StreamReader lectorTemporal = new StreamReader(flujoTemporal);
                
            }

            //File.WriteAllText();



            //richTextBoxModificado.Text = lector.ReadToEnd();
            //flujo.Seek(0, SeekOrigin.Begin);
        }

        private void SeleccionarFile()
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog1.FileName;
                nombreArchivo = Path.GetFileName(openFileDialog1.FileName);
                rutaProyecto = Application.StartupPath;
                labelNombreArchivoOriginal.Text = Path.GetFileName(rutaArchivo);
                toolStripStatusLabel1.Text = rutaArchivo;

                AbrirFlujo(rutaArchivo, FileMode.Open, FileAccess.ReadWrite);

                richTextBoxOriginal.Text = lector.ReadToEnd();
                flujo.Seek(0, SeekOrigin.Begin);
                richTextBoxModificado.Text = lector.ReadToEnd();
                flujo.Seek(0, SeekOrigin.Begin);

                textBoxOutput.Enabled = true;
                textBoxInput.Enabled = true;
            }
        }

        private void seleccionarNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e) => SeleccionarFile();


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