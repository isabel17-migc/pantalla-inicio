using pantalla_loig_in;

namespace pantalla_inicio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Longin1 longin = new Longin1();
            //"Longin1" es el nombre del formulario, "longin" es el nombre de la variable que va a aguardar la ventana del formulario
            //El new Longin1(); Crea una instancia nueva de esa clase, es decir, construye la ventana real en memoria. new es el operador que crea el objeto

            longin.FormClosed += (s, args) => Application.Exit();
            // A la ventana login, en su evento de cerrar (FormClosed), se le agrega con += la acción de cerrar la aplicación.
            // Así, cuando el usuario cierre el login, se ejecutará Application.Exit() y la aplicación se cerrará.

            // (s, args)... s= sender (quiem lanzo el evento), args=argumentos del evento (detalles de lo que paso)

            longin.Show();
            this.Hide();
        }
    }
}
