using Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void AceptarButton_Click(
            object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un código de usuario");
                CodigoUsuarioTextBox.Focus();
                return;
            }
        }
}
}