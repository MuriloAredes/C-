using banco_de_dados.Modelo;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ProjetoLogin.DAL
{
    class LoginDaoComandos
    {  
        public bool tem = false;
        public String mensagem ="";
        SqlCommand cmd = new SqlCommand();
        conexao con = new conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha) //vai no banco verificar se tem 
        {
         

            // comandos sql para verificar se tem no banco 
            cmd.CommandText = "select * from logins where email = @login and senha = @senha ;";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            // metodo criptografia
            try 
            {
             
                cmd.Connection = con.conectar();
               dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            } catch (SqlException) 
            {
                this.mensagem = "Erro com Banco de Dados";
                throw;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha) 
        {
           
                tem = false;
            // comandos para inserir usuario
            if (senha.Equals(confSenha))
            {
                
                cmd.CommandText = "insert into logins Values(@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado Com Sucesso!";
                    tem = true;

                }
                catch (SqlException)
                { this.mensagem = "Erro com Banco de Dados "; }
            }
            else 
            {
                this.mensagem = "Senhas não Correspondem!";
            }
            return mensagem;
        }
    }
}
