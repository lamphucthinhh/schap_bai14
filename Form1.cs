using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schap_bai5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radRed.Checked = true;
            radRed.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            radRed.ForeColor = Color.Red;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Red;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font(lblLaptrinh.Font.Name, lblLaptrinh.Font.Size, lblLaptrinh.Font.Style ^ FontStyle.Underline);

        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
           lblLaptrinh.ForeColor = Color.LimeGreen;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
           lblLaptrinh.ForeColor = Color.Blue;
        }
        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Blue;
        }
    }
}