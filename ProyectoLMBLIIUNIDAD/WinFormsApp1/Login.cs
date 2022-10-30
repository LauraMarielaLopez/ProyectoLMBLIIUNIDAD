using Datos;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CodigoUsuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigoUsuarioTextBox, "Ingrese un c�digo de usuario");
                CodigoUsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClaveTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ClaveTextBox, "Ingrese una clave");
                ClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();

            bool valido = await userDatos.LoginAsync(CodigoUsuarioTextBox.Text, ClaveTextBox.Text);

            if (valido)
            {
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void CancelarButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}