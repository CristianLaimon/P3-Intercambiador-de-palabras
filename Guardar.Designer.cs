namespace SesmaSantiago_RuizLimon_Practica3
{
    partial class Guardar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSeleccionarDirectorio = new System.Windows.Forms.Button();
            this.textBoxRutaNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota: Deje en blanco para nombre y/o ubicación por defecto";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(145, 24);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(283, 27);
            this.textBoxNewName.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(236, 128);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(123, 36);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(365, 128);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(123, 36);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionarDirectorio
            // 
            this.buttonSeleccionarDirectorio.Location = new System.Drawing.Point(438, 72);
            this.buttonSeleccionarDirectorio.Name = "buttonSeleccionarDirectorio";
            this.buttonSeleccionarDirectorio.Size = new System.Drawing.Size(37, 32);
            this.buttonSeleccionarDirectorio.TabIndex = 5;
            this.buttonSeleccionarDirectorio.Text = "...";
            this.buttonSeleccionarDirectorio.UseVisualStyleBackColor = true;
            // 
            // textBoxRutaNueva
            // 
            this.textBoxRutaNueva.Location = new System.Drawing.Point(143, 74);
            this.textBoxRutaNueva.Name = "textBoxRutaNueva";
            this.textBoxRutaNueva.Size = new System.Drawing.Size(284, 27);
            this.textBoxRutaNueva.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ubicación:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SesmaSantiago_RuizLimon_Practica3.Properties.Resources.free_folder_icon_1484_thumb;
            this.pictureBox1.Location = new System.Drawing.Point(31, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 219);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRutaNueva);
            this.Controls.Add(this.buttonSeleccionarDirectorio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Guardar";
            this.Text = "Guardar";
            this.Load += new System.EventHandler(this.Guardar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNewName;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private Button buttonSeleccionarDirectorio;
        private TextBox textBoxRutaNueva;
        private Label label3;
        private PictureBox pictureBox1;
    }
}