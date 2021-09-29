using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.Control;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  void CleanTextbox() 
        {
            textBoxNome.Text = ("");
            textBoxTelefone.Text = ("");
            textBoxEmail.Text = ("");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   // instanciando e pegando texto das textbox
            add cadastrar = new add(textBoxNome.Text, textBoxTelefone.Text, textBoxEmail.Text);
            MessageBox.Show(cadastrar.message);
            Consultar consulta = new Consultar();
            consulta.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {   // vai chamar a tela de view
            Consultar consultar = new Consultar();

            consultar.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
