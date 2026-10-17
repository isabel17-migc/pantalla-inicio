namespace dassh_board
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void btnbiblioteca_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Botón Biblioteca
            if (btnbiblioteca.Image != null)
            {
                btnbiblioteca.Image = new Bitmap(btnbiblioteca.Image, new Size(24, 24));
                btnbiblioteca.ImageAlign = ContentAlignment.MiddleLeft;
                btnbiblioteca.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            // Botón Agregar
            if (btnagg.Image != null)
            {
                btnagg.Image = new Bitmap(btnagg.Image, new Size(24, 24));
                btnagg.ImageAlign = ContentAlignment.MiddleLeft;
                btnagg.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            // Botón Usuario
            if (btnusuario.Image != null)
            {
                btnusuario.Image = new Bitmap(btnusuario.Image, new Size(24, 24));
                btnusuario.ImageAlign = ContentAlignment.MiddleLeft;
                btnusuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            // Botón Cerrar
            if (btncerrar.Image != null)
            {
                btncerrar.Image = new Bitmap(
                    btncerrar.Image, new Size(24, 24));

                btncerrar.ImageAlign = ContentAlignment.MiddleLeft;
                btncerrar.TextImageRelation =
                    TextImageRelation.ImageBeforeText;
            }

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }
    }
}
