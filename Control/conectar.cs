using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cadastro.Control
{
    class conectar
    {
        SqlConnection Con = new SqlConnection();
        public conectar()  
        {
            //construtor conect
            Con.ConnectionString = @"Data Source=DESKTOP-T6CB2TC\SQLEXPRESS;Initial Catalog=ConectProject;Integrated Security=True ";

        }

    

        public SqlConnection Connect() 
        {   // vai conectar com o banco 

            if (Con.State == System.Data.ConnectionState.Closed) 
            {
                Con.Open();
            }
            return Con;
        }

        public void Disconnect() 
        {
            // desconectar
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
            
        }

        
    }
}
