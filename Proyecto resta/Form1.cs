using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_resta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clresta SS = new clresta();

            SS.N1 = int.Parse(textBox1.Text);
            SS.N2 = int.Parse(textBox2.Text);

            textBox3.Text = SS.resta().ToString();

            clresta KK = new clresta(int.Parse(textBox1.Text),
            int.Parse(textBox2.Text)); textBox3.Text = KK.resta().ToString();

        }
    }
}
