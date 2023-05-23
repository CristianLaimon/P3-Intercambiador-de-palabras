namespace SesmaSantiago_RuizLimon_Practica3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarNuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBoxOriginal = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTextoRemplazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxModificado = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNombreArchivoOriginal = new System.Windows.Forms.Label();
            this.labelNombreArchivoModificado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPorReemplazar = new System.Windows.Forms.TextBox();
            this.labelNoRemplazos = new System.Windows.Forms.Label();
            this.statusStripPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 664);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(797, 26);
            this.statusStripPrincipal.TabIndex = 1;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.créditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarNuevoArchivoToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.aToolStripMenuItem.Text = "Abrir";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // seleccionarNuevoArchivoToolStripMenuItem
            // 
            this.seleccionarNuevoArchivoToolStripMenuItem.Name = "seleccionarNuevoArchivoToolStripMenuItem";
            this.seleccionarNuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.seleccionarNuevoArchivoToolStripMenuItem.Text = "Seleccionar nuevo archivo...";
            this.seleccionarNuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarNuevoArchivoToolStripMenuItem_Click);
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.créditosToolStripMenuItem.Text = "Créditos";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBoxOriginal
            // 
            this.richTextBoxOriginal.Location = new System.Drawing.Point(30, 192);
            this.richTextBoxOriginal.Name = "richTextBoxOriginal";
            this.richTextBoxOriginal.ReadOnly = true;
            this.richTextBoxOriginal.Size = new System.Drawing.Size(345, 374);
            this.richTextBoxOriginal.TabIndex = 3;
            this.richTextBoxOriginal.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "ReemplazadorInador";
            // 
            // textBoxTextoRemplazar
            // 
            this.textBoxTextoRemplazar.Location = new System.Drawing.Point(249, 111);
            this.textBoxTextoRemplazar.Name = "textBoxTextoRemplazar";
            this.textBoxTextoRemplazar.Size = new System.Drawing.Size(186, 27);
            this.textBoxTextoRemplazar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Texto a reemplazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vista Previa";
            // 
            // richTextBoxModificado
            // 
            this.richTextBoxModificado.Location = new System.Drawing.Point(416, 192);
            this.richTextBoxModificado.Name = "richTextBoxModificado";
            this.richTextBoxModificado.ReadOnly = true;
            this.richTextBoxModificado.Size = new System.Drawing.Size(360, 374);
            this.richTextBoxModificado.TabIndex = 9;
            this.richTextBoxModificado.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelNombreArchivoOriginal
            // 
            this.labelNombreArchivoOriginal.AutoSize = true;
            this.labelNombreArchivoOriginal.Location = new System.Drawing.Point(28, 574);
            this.labelNombreArchivoOriginal.Name = "labelNombreArchivoOriginal";
            this.labelNombreArchivoOriginal.Size = new System.Drawing.Size(239, 20);
            this.labelNombreArchivoOriginal.TabIndex = 11;
            this.labelNombreArchivoOriginal.Text = "No se ha seleccionado un archivo...";
            // 
            // labelNombreArchivoModificado
            // 
            this.labelNombreArchivoModificado.AutoSize = true;
            this.labelNombreArchivoModificado.Location = new System.Drawing.Point(416, 574);
            this.labelNombreArchivoModificado.Name = "labelNombreArchivoModificado";
            this.labelNombreArchivoModificado.Size = new System.Drawing.Size(239, 20);
            this.labelNombreArchivoModificado.TabIndex = 12;
            this.labelNombreArchivoModificado.Text = "No se ha seleccionado un archivo...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "por";
            // 
            // textBoxPorReemplazar
            // 
            this.textBoxPorReemplazar.Location = new System.Drawing.Point(480, 114);
            this.textBoxPorReemplazar.Name = "textBoxPorReemplazar";
            this.textBoxPorReemplazar.Size = new System.Drawing.Size(186, 27);
            this.textBoxPorReemplazar.TabIndex = 14;
            // 
            // labelNoRemplazos
            // 
            this.labelNoRemplazos.AutoSize = true;
            this.labelNoRemplazos.Location = new System.Drawing.Point(28, 634);
            this.labelNoRemplazos.Name = "labelNoRemplazos";
            this.labelNoRemplazos.Size = new System.Drawing.Size(149, 20);
            this.labelNoRemplazos.TabIndex = 15;
            this.labelNoRemplazos.Text = "No. de reemplazos: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 690);
            this.Controls.Add(this.labelNoRemplazos);
            this.Controls.Add(this.textBoxPorReemplazar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNombreArchivoModificado);
            this.Controls.Add(this.labelNombreArchivoOriginal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxModificado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTextoRemplazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxOriginal);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem seleccionarNuevoArchivoToolStripMenuItem;
        private ToolStripMenuItem créditosToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox richTextBoxOriginal;
        private Label label1;
        private TextBox textBoxTextoRemplazar;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBoxModificado;
        private Button button1;
        private Label labelNombreArchivoOriginal;
        private Label labelNombreArchivoModificado;
        private Label label5;
        private TextBox textBoxPorReemplazar;
        private Label labelNoRemplazos;
    }
}