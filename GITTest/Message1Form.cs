using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class Message1Form : Form
    {
        public Message1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Message1Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want close the Message1?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
