namespace ProvaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // Cria um novo usu�rio com os dados do formul�rio
            Usuario novoUsuario = new Usuario()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text

            };

            bool sucesso = Database.SalvarUsuario(novoUsuario);

        }

        private static Usuario novoUsuario;

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

