namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Form1 : Form
    {
        private static Form1 instancia;
        private StreamWriter escritor;
        private FileStream flujo;
        private StreamReader lector;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var guardarForm = new Guardar();
            guardarForm.Show();
            guardarForm.BringToFront();
            this.Enabled = false;
        }

        private void buttonSeleccionarArchivo_Click(object sender, EventArgs e) => SeleccionarFile();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "Modificados")))
            {
                Directory.CreateDirectory("Modificados");
            }
            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Originales");
            toolStripStatusLabel1.Text = "Hecho por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
            textBoxInput.Enabled = false;
            textBoxOutput.Enabled = false;
        }

        private void SeleccionarFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                labelNombreArchivoOriginal.Text = Path.GetFileName(openFileDialog1.FileName);
                toolStripStatusLabel1.Text = openFileDialog1.FileName;

                AbrirFlujo(openFileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite);

                richTextBoxOriginal.Text = lector.ReadToEnd();
                flujo.Seek(0, SeekOrigin.Begin);
                richTextBoxModificado.Text = lector.ReadToEnd();
                flujo.Seek(0, SeekOrigin.Begin);

                textBoxOutput.Enabled = true;
                textBoxInput.Enabled = true;


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

        private void seleccionarNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e) => SeleccionarFile();

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void algo()
        {

            string input = textBoxInput.Text, output = textBoxOutput.Text, texto = richTextBoxOriginal.Text;
            string textoModificado = texto.Replace(input, output);

            File.WriteAllText(openFileDialog1.FileName, textoModificado);

            richTextBoxModificado.Text = lector.ReadToEnd();
            flujo.Seek(0, SeekOrigin.Begin);

        }

        private void textBoxOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}