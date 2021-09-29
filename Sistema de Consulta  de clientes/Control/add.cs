using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro;


namespace Cadastro.Control
{
    class add : Form1
    {

 
        conectar conexao = new conectar();
        SqlCommand comando = new SqlCommand();
        public string message = "";
        public bool check = false;


        public add(String nome, String telefone, String email)
        {
            // comandos slq
            comando.CommandText = "INSERT INTO CAD(nome, email, telefone) VALUES(@nome, @email, @telefone) ";

          // comando.Parameters.AddWithValue("@Id", random.Next());
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telefone", telefone);

            try
            {   // conecta no banco 
                comando.Connection = conexao.Connect();
                // executa o comando 
                comando.ExecuteNonQuery();
                // desconecta do banco
                conexao.Disconnect();
                this.message = "Cadastrado com Sucesso!! ";
                
                
                
                
            }



            catch (SqlException x)
            {
                this.message = "Erro ao tentar conexão com o banco" + x;
            }


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(499, 428);
            this.Name = "add";
            this.Load += new System.EventHandler(this.add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
