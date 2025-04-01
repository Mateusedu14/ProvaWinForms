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
            string telefone = txtTelefone.Text;


            if (Database.TelefoneExiste(telefone))
            {
                MessageBox.Show("Este telefone j� est� cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Usuario novoUsuario = new Usuario()
            {
                Nome = txtNome.Text,
                Telefone = telefone
            };

            bool sucesso = Database.SalvarUsuario(novoUsuario);

            if (sucesso)
            {
                MessageBox.Show("Usu�rio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao salvar o usu�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Usuario novoUsuario;

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


