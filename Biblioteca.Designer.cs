namespace Biblioteca
{
    partial class Biblioteca1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca1));
            panel1 = new Panel();
            button1 = new Button();
            btncerrar = new Button();
            btnbiblioteca = new Button();
            btnusuario = new Button();
            btnagg = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(btnbiblioteca);
            panel1.Controls.Add(btnusuario);
            panel1.Controls.Add(btnagg);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 691);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkMagenta;
            button1.Image = pantalla_inicio.Properties.Resources.BIBLIOTECA;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 168);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 57);
            button1.TabIndex = 12;
            button1.Text = "  BIBLIOTECA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btncerrar
            // 
            btncerrar.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncerrar.Image = pantalla_inicio.Properties.Resources.cerrar_seccion;
            btncerrar.ImageAlign = ContentAlignment.TopLeft;
            btncerrar.Location = new Point(10, 613);
            btncerrar.Margin = new Padding(3, 4, 3, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(171, 40);
            btncerrar.TabIndex = 11;
            btncerrar.Text = "  Cerrar seción";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnbiblioteca
            // 
            btnbiblioteca.BackgroundImageLayout = ImageLayout.Center;
            btnbiblioteca.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbiblioteca.ForeColor = Color.DarkMagenta;
            btnbiblioteca.Image = pantalla_inicio.Properties.Resources.inicio1;
            btnbiblioteca.ImageAlign = ContentAlignment.MiddleLeft;
            btnbiblioteca.Location = new Point(10, 43);
            btnbiblioteca.Margin = new Padding(3, 4, 3, 4);
            btnbiblioteca.Name = "btnbiblioteca";
            btnbiblioteca.Size = new Size(171, 57);
            btnbiblioteca.TabIndex = 8;
            btnbiblioteca.Text = "INICIO";
            btnbiblioteca.UseVisualStyleBackColor = true;
            btnbiblioteca.Click += btnbiblioteca_Click;
            // 
            // btnusuario
            // 
            btnusuario.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusuario.ForeColor = Color.DarkMagenta;
            btnusuario.Image = pantalla_inicio.Properties.Resources.USUARIO;
            btnusuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuario.Location = new Point(10, 447);
            btnusuario.Margin = new Padding(3, 4, 3, 4);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(171, 57);
            btnusuario.TabIndex = 10;
            btnusuario.Text = "    CUENTA/USUARIO";
            btnusuario.UseVisualStyleBackColor = true;
            btnusuario.Click += btnusuario_Click;
            // 
            // btnagg
            // 
            btnagg.Font = new Font("Segoe UI Emoji", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagg.ForeColor = Color.DarkMagenta;
            btnagg.Image = pantalla_inicio.Properties.Resources.agregar_libro__2_;
            btnagg.ImageAlign = ContentAlignment.MiddleLeft;
            btnagg.Location = new Point(10, 303);
            btnagg.Margin = new Padding(3, 4, 3, 4);
            btnagg.Name = "btnagg";
            btnagg.Size = new Size(171, 57);
            btnagg.TabIndex = 9;
            btnagg.Text = "     AGREGAR LIBROS";
            btnagg.UseVisualStyleBackColor = true;
            btnagg.Click += btnagg_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(582, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(750, 11);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Biblioteca1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = pantalla_inicio.Properties.Resources.FONDO3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(928, 691);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Biblioteca1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The BookWorm Society";
            Load += Biblioteca1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button btncerrar;
        private Button btnbiblioteca;
        private Button btnusuario;
        private Button btnagg;
    }
}
