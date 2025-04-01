using System;
using MySql.Data.MySqlClient;

namespace ProvaWinForms
{
    public static class Database
    {
        
        public static bool TelefoneExiste(string telefone)
        {
            string connectionString = "Server=localhost;Port=3306;User Id=root; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE Telefone = @Telefone";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Telefone", telefone);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0; 
            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
                return false; 
            }
            finally
            {
                conexao.Close();
            }
        }

       
        public static bool SalvarUsuario(Usuario usuario)
        {
            string connectionString = "Server=localhost;Port=3306;User Id=root; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();
                string query = "INSERT INTO usuario (Nome, Telefone) VALUES (@Nome, @Telefone)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);

                int quantidade = cmd.ExecuteNonQuery();
                return quantidade > 0; 
            }
            catch (Exception ex)
            {
                // Tratar qualquer erro de conexão
                Console.WriteLine(ex.Message);
                return false; 
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}


