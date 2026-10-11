namespace pantalla_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbltitulo = new Label();
            piclogo = new PictureBox();
            btniniciar = new Button();
            lblfrase = new Label();
            linkpolitica = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Thistle;
            lbltitulo.Font = new Font("Stencil", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(94, 29);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(379, 34);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "THE BOOKWORM SOCIETY";
            lbltitulo.UseWaitCursor = true;
            // 
            // piclogo
            // 
            piclogo.BackgroundImage = (Image)resources.GetObject("piclogo.BackgroundImage");
            piclogo.BackgroundImageLayout = ImageLayout.Stretch;
            piclogo.BorderStyle = BorderStyle.Fixed3D;
            piclogo.Location = new Point(12, 12);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(76, 79);
            piclogo.SizeMode = PictureBoxSizeMode.CenterImage;
            piclogo.TabIndex = 1;
            piclogo.TabStop = false;
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.Plum;
            btniniciar.FlatStyle = FlatStyle.Popup;
            btniniciar.Font = new Font("Rockwell", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btniniciar.ForeColor = Color.Black;
            btniniciar.ImageAlign = ContentAlignment.TopCenter;
            btniniciar.Location = new Point(159, 260);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(181, 42);
            btniniciar.TabIndex = 2;
            btniniciar.Text = "INICIAR";
            btniniciar.UseVisualStyleBackColor = false;
            // 
            // lblfrase
            // 
            lblfrase.AutoSize = true;
            lblfrase.BorderStyle = BorderStyle.FixedSingle;
            lblfrase.FlatStyle = FlatStyle.Flat;
            lblfrase.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfrase.ForeColor = Color.DarkMagenta;
            lblfrase.Location = new Point(63, 441);
            lblfrase.Name = "lblfrase";
            lblfrase.Size = new Size(387, 27);
            lblfrase.TabIndex = 3;
            lblfrase.Text = "Tus libros, tus reseñas, tu historia de lectura";
            // 
            // linkpolitica
            // 
            linkpolitica.AutoSize = true;
            linkpolitica.BorderStyle = BorderStyle.Fixed3D;
            linkpolitica.Location = new Point(320, 502);
            linkpolitica.Name = "linkpolitica";
            linkpolitica.Size = new Size(168, 17);
            linkpolitica.TabIndex = 4;
            linkpolitica.TabStop = true;
            linkpolitica.Text = "VER POLITICA DE PRIVACIDAD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 528);
            Controls.Add(linkpolitica);
            Controls.Add(lblfrase);
            Controls.Add(btniniciar);
            Controls.Add(piclogo);
            Controls.Add(lbltitulo);
            Name = "Form1";
            Text = "MIS LIBROS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private PictureBox piclogo;
        private Button btniniciar;
        private Label lblfrase;
        private LinkLabel linkpolitica;
    }
}
