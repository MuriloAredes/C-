using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using banco_de_dados.Apresentacao;
using ProjetoLogin.Modelo;
using System.IO;

namespace banco_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {   //Aqui é o botão de sair da interface
            Application.Exit();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {   //Aquii é o botao que chama o cadastro
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {    // Aquii é o botao de Entrar interface
            
            DialogResult = DialogResult.OK;
            controle controle = new controle();
            controle.acessar(textBoxNome.Text, textBoxSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                
                if (controle.tem)
                {
                   
                   
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindas bv = new BemVindas();
                       
                   
                    bv.Show();
                    this.Hide();
            
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show(controle.mensagem);

            }
            //fim do botao entrar
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonEntrar; // quando tiver na textBoxsenha apertar entender

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  if (checkBox1.Checked)
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBancoDados.txt",true);
                arquivo.WriteLine(textBoxNome);
                //arquivo.WriteLine(textBoxSenha.Text);
               
                arquivo.Close();
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
