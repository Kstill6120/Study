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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public double GiaiPtrinhBacMot(double a, double b)
        {
            return -b / a;
        }
        public void GiaiPtrinhBacHai(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
                T4.Text = "Phường trình vô nghiệm!";
            else if (delta == 0)
            {
                T4.Text = "Phương trình có nghiệm kép:" + "\n" + "x = " + (-b / (2 * a));
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                T4.Text = "Phương trình có 2 nghiệm phân biệt:" + Environment.NewLine +
                             "x1 = " + x1.ToString("0.00") + Environment.NewLine +
                             "x2 = " + x2.ToString("0.00");
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            B1.Enabled = false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (R1.Checked)
            {
                B1.Enabled = true;
            T3.Enabled = false;
            T4.Enabled = false;
            }

        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            Control T1 = (Control)sender;
            if (!T1.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T1, "Nhập sai");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void T2_TextChanged(object sender, EventArgs e)
        {
            Control T2 = (Control)sender;
            if (!T2.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T2, "Nhập sai");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void T3_TextChanged(object sender, EventArgs e)
        {
            Control T3 = (Control)sender;
            if (!T3.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T3, "Nhập sai");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        public void ClearTxt()
        {
            T1.Clear();
            T2.Clear();
            T3.Clear();
            T4.Clear();
        }
        private void B1_Click(object sender, EventArgs e)
        {

            double a = double.Parse(T1.Text);
            double b = double.Parse(T2.Text);
            double c = 0;
            if (T3.Text.Length != 0)
                c = double.Parse(T3.Text);
            if (R1.Checked)
            {
                ClearTxt();
                T4.Text = GiaiPtrinhBacMot(a, b).ToString();
            }
            else if (R2.Checked)
            {
                ClearTxt();
                GiaiPtrinhBacHai(a, b, c);
            }
            else
                MessageBox.Show("Bạn chưa chọn loại phương trình!", "Thông báo");
        }

        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            T3.Enabled = true;
        }
    }
}
