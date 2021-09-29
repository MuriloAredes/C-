using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLogin.Modelo;

namespace banco_de_dados.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CadastreSe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            String mensagem = controle.cadastrar(textBoxLogin.Text, textBoxSenha.Text, textBoxConfirmSenha.Text);

            if (controle.tem)
            {
                MessageBox.Show(mensagem, " Cadastro ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else 
            {
                MessageBox.Show(controle.mensagem);
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
