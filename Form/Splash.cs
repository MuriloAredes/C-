using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
          
           
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else 
            {
                timer1.Enabled = false;
                iniciar();
                this.Hide();

            }

           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

      
        public void iniciar() 
        {
            if (ChiCheckForInternetConnection() == true)
            {
                Consultar consultar = new Consultar();
                consultar.Show();
            }
            else 
            {
                MessageBox.Show("Sem conexão a rede");
            }
        }

        public bool ChiCheckForInternetConnection()
        {  // Aqui ele vai retornar se tiver conectivivade com a rede 
            try
            {
                using (var client = new WebClient())
                {
                    WebProxy wp = new WebProxy();
                    client.Proxy = wp;
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        
                        return true;
                    }
                }
               
            }
            catch
            {
               
                return false;
            }
        }
    }
}
