using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            T2.Enabled = false;
            T3.Enabled = false;
            T4.Enabled = false;
            T5.Enabled = false;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            T1.ResetText();
            T2.ResetText();
            T3.ResetText();
            T4.ResetText();
            T5.ResetText();
            T1.Focus();
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            Control T1 = (Control)sender;
            if (!T1.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T1, "Nhập sai số");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        int tong, tongc, tongl = 0;
        private void B1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(T1.Text);
                T2.Text += a.ToString() + " ";
                T3.Text=(tong += a).ToString();
                if (a % 2 == 0)
                {
                    T4.Text=(tongc += a).ToString();
                }
                else
                {
                    T5.Text = (tongl += a).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Nhập sai", "Sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            T1.ResetText();
            T1.Focus();
        }
    }
}
