using dassh_board;
using pantalla_inicio;
using System.Data.SqlTypes;

namespace pantalla_loig_in
{
    public partial class Longin1 : Form
    {
        public Longin1()
        {
            InitializeComponent();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Dashboard1 dashboard = new Dashboard1();

            dashboard.FormClosed += (s, args) => Application.Exit();

            dashboard.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Crear_Cuenta1 crear_cuenta = new Crear_Cuenta1();

            crear_cuenta.FormClosed += (s , args) =>  Application.Exit();

            crear_cuenta.Show();
            this.Hide();
        }
    }
}
