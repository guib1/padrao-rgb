using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace padrão_rgb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox1.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox2.Text = Convert.ToString(hScrollBar2.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            hScrollBar1.Value = 0;
            hScrollBar2.Value = 0;
            hScrollBar3.Value = 0;
            label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox3.Text = Convert.ToString(hScrollBar3.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finalizar", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
              DialogResult.Yes)
                Application.Exit();
        }
    }
}
