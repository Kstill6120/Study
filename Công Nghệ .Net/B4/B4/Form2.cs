using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (R4.Checked)
            {
                L1.ForeColor = Color.Blue;
            }
        }

        private void CB1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB1.Checked)
            {
                L1.Font = new Font(L1.Font, FontStyle.Regular);
            }
        }

        private void CB2_CheckedChanged(object sender, EventArgs e)
        {
            if (CB2.Checked)
            {
                L1.Font = new Font(L1.Font, FontStyle.Bold);
            }
        }

        private void CB3_CheckedChanged(object sender, EventArgs e)
        {
            if (CB3.Checked)
            {
                L1.Font = new Font(L1.Font, FontStyle.Italic);
            }
        }

        private void CB4_CheckedChanged(object sender, EventArgs e)
        {
            if (CB4.Checked)
            {
                L1.Font = new Font(L1.Font,(FontStyle)( FontStyle.Bold | FontStyle.Italic));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            if (R1.Checked)
            {
                Random rand = new Random();
                int red = rand.Next(0, 256);
                int green = rand.Next(0, 256);
                int blue = rand.Next(0, 256);

                L1.ForeColor = Color.FromArgb(red, green, blue);
            }
        }

        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            if (R2.Checked)
            {
                L1.ForeColor = Color.Red;
            }
           
        }

        private void R3_CheckedChanged(object sender, EventArgs e)
        {
            if (R3.Checked)
            {
                L1.ForeColor = Color.Green;
            }
        }
    }
}
