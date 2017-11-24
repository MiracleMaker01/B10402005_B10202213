using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B10402005_B10202213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            A obj = new A();
            int n = obj.randNumber();
            label1.Text = n.ToString();

            for (int i = 2; i <= n; i++)
            {
                B obj_b = new B();
                Boolean bol = obj_b.IsPrime(i);
                if (bol == true)
                {
                    comboBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
