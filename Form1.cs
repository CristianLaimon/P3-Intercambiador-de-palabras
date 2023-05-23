namespace SesmaSantiago_RuizLimon_Practica3
{
    public partial class Form1 : Form
    {
        private static Form1 instancia;

        public Form1()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public static Form1 Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Form1();
                }
                return instancia;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar.Instancia.Show();
            Guardar.Instancia.BringToFront();
            this.Enabled = false;

            
        }
    }
}