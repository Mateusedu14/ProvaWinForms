using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;


namespace ProvaWinForms
{ 
public static class Database
{
    //Implemente o método SalvarUsuario
    public static bool SalvarUsuario(Usuario usuario)
    {


        string connectionString = "Server=localhost;Port=3306;User Id=root" +
                "; database=ti_113_windowsforms;";

            MySqlConnection conexao = new MySqlConnection(connectionString);
            conexao.Open();


            string query = "insert into usuario (Nome, Telefone)" +
            "values (@Nome, @Telefone)";
        MySqlCommand cmd = conexao.CreateCommand();
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
        cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
        int quantidade = cmd.ExecuteNonQuery()
        conexao.Close();
        if (quantidade == 0)
            return false;
        else
            return true;


    }

}

}

