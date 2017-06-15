using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abrir = new Form2();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 abrir = new Form3();
            abrir.Show();
        }
    }
}
