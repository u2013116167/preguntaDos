using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float al = float.Parse(textBox2.Text);
            float pes= float.Parse(textBox1.Text);
            float imc = pes / (al * al);
            textBox3.Text = Convert.ToString(imc);
            if (imc<30) {
                if (imc>24.9) { label4.Text ="Aumentado"; }
                else { label4.Text = "Promedio"; }
            }
            else if (imc>29.9 && imc<40) {
                if (imc<35) { label4.Text = "Moderado"; }
                else { label4.Text = "Severo"; }
            }

            else { label4.Text = "Muy Severo"; }
          }

       
    }
}
