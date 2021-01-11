using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;

            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

            textBoxU.BackColor = Color.FromArgb(149, 165, 166);
            textBoxP.BackColor = Color.FromArgb(149, 165, 166);
            textBoxU.ForeColor = Color.FromArgb(255, 255, 255);
            textBoxP.ForeColor = Color.FromArgb(255, 255, 255);


            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.ForeColor = Color.White;
           


        }
       


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Hello "+textBoxU.Text;
        }

        private void textBoxU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}