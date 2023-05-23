namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Form1 : Form
    {
        private static Form1 instancia;

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
                    //foreach (Form form in Application.OpenForms)
                    //{
                    //    if (form is Form1)
                    //    {
                    //        instancia = (Form1)form;
                    //        break;
                    //    }
                    //}

                    instancia = (Form1)Application.OpenForms[0];
                }
                return instancia;
            }
        }
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var guardarForm = new Guardar();
           guardarForm.Show();
           guardarForm.BringToFront();
           this.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "Modificados")))
            {
                Directory.CreateDirectory("Modificados");
            }
            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "Modificados");
            toolStripStatusLabel1.Text = "Hecho por: Diana Sesma Yulissa Santiago y Kristan Ruíz Limón";
        }

        private void seleccionarNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelNombreArchivoOriginal.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }
    }
}