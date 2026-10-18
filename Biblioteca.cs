using Apartado_de_Libros_proyecto_progra_III;
using dassh_board;
using pantalla_loig_in;

namespace Biblioteca
{
    public partial class Biblioteca1 : Form
    {
        public Biblioteca1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Biblioteca1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

        }

        private void btnagg_Click_1(object sender, EventArgs e)
        {
            AddLibro1 agregar_libros = new AddLibro1();

            agregar_libros.FormClosed += (s, args) => Application.Exit();

            agregar_libros.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Biblioteca1 biblioteca = new Biblioteca1();

            biblioteca.FormClosed += (s, args) => Application.Exit();

            biblioteca.Show();
            this.Hide();
        }

        private void btnbiblioteca_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();

            longin.FormClosed += (s, args) => Application.Exit();

            longin.Show();
            this.Hide();
        }
    }
}
