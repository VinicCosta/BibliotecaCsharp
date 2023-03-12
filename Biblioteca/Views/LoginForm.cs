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
            // valida o login
           if(ctr.ValidarEmail(txtEmail.Text) && ctr.ValidarSenha(txtSenha.Text))
            {
                MessageBox.Show("Email e senha validados com sucesso");
            }
        }
    }
}