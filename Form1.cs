using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tallernet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OPERADOR OP = new OPERADOR();
            OP.Show();
            this.Hide();
        }

        private void PtcConversion_Click(object sender, EventArgs e)
        {
            PESO peso = new PESO();
            peso.Show();
            this.Hide();

        }

        private void PctSalario_Click(object sender, EventArgs e)
        {
            AUMENTOSALARIO AUMEN = new AUMENTOSALARIO();
            AUMEN.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
