using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco_de_dados.Apresentacao
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {     //tela de carregamento splash
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            lblCarregando.Text = progressBar1.Value + "%"; // Aqui faz o label ganhar porcentagem exemplo 0% a 100%

            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            } 
            if(progressBar1.Value == 100)
            {
                Form1 form1 = new Form1();//instancia
                timer1.Stop();//parando o time
                this.Hide();//fecha a janela
                form1.Show();//tela de login
            }        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
