using Cadastro.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Consultar : Form
    {
        private string _str = @"Data Source=DESKTOP-T6CB2TC\SQLEXPRESS;Initial Catalog=ConectProject;Integrated Security=True ";
        conectar conectar = new conectar();
        SqlConnection objConect = null;
        SqlCommand cmd = new SqlCommand();

        SqlCommand objCommand = null;

        public Consultar()
        {
            InitializeComponent();
            listarTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // Form Cadastrar 
            Form1 Form1 = new Form1();
            Form1.Show();
            Hide();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Desenvolvido por Murilo Aredes \n  Contato : murilohenrique467@gmail.com");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listarTodos()
        {
            //commando sql
            string StrSql = "SELECT* FROM CAD";
            //Conexao com banco 
            objConect = new SqlConnection(_str);
            //comando e conecta com o banco
            objCommand = new SqlCommand(StrSql, objConect);


            SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);

            DataTable dtLista = new DataTable();

            objAdp.Fill(dtLista);

            dataGridView1.DataSource = dtLista;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Del = @"DELETE CAD WHERE  Id= @Id";

            cmd = new SqlCommand(Del, objConect);
            cmd.Parameters.AddWithValue("@Id", textBoxId.Text);
            try
            {

                //conecta com o banco 
                cmd.Connection = conectar.Connect();

                //Executa o comando 
                cmd.ExecuteNonQuery();
                listarTodos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectar.Disconnect();
            }


        }
    }
}
