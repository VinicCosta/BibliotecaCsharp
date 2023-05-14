using Biblioteca.Services;
namespace Biblioteca
{
    public partial class LoginForm : Form
    {
        Controller ctr = new Controller();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            // valida o login e colore de verde
            if(ctr.ValidarEmail(txtEmail.Text) && ctr.ValidarSenha(txtSenha.Text))
            {
                txtEmail.BackColor = Color.LightGreen;
                txtSenha.BackColor = Color.LightGreen;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ctr.Cancelar();
        }
    }
}