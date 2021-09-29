using System;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace ProjetoLogin.DAL
{
    public class conexao
    {
            SqlConnection con = new SqlConnection();
        public conexao() 
        {
            con.ConnectionString = @"Data Source=DESKTOP-HC33J3F\SQLEXPRESS;Initial Catalog=teste;Integrated Security=True";
        }

        public SqlConnection conectar() 
        {
            if (con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }

        public void desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
