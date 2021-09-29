using System;

using System.Windows.Forms;

namespace TIMER
{
    public partial class Timer : Form
    {
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;

        public Timer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempo = Convert.ToInt16(textBox1.Text);

            if (tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            } else
            {
                minuto = 0;
                segundo = segundo;
            }
            label2.Text = "0" + minuto + ":" + segundo;

            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0) 
            {
                if (segundo < 0) 
                {
                    segundo = 59;
                    minuto--;
                }
            }
            label2.Text = "0" + minuto + ":" + segundo;
            if (minuto == 0 && segundo == 0) 
            {
                timer1.Enabled = false;
                pictureBox1.Visible = true;
                
            }
        }
    }
}
