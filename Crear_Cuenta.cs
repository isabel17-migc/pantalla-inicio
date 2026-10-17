using pantalla_loig_in;

namespace pantalla_inicio
{
    public partial class Crear_Cuenta1 : Form
    {
        public Crear_Cuenta1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();

            longin.FormClosed += (s, args) => Application.Exit();

            longin.Show();
            this.Hide();
        }
    }
}
