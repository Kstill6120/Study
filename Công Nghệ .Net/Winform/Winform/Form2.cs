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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r= MessageBox.Show("Bạn có muốn thoát","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            Control T1= (Control)sender;
            if(!T1.Text.All(char.IsDigit) )
            {
                this.errorProvider1.SetError(T1,"Nhập sai");
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

        private void B1_Click(object sender, EventArgs e)
        {
            try
            {
            T3.Text=(double.Parse(T1.Text)+double.Parse(T2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập sai","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void B2_Click(object sender, EventArgs e)
        {
            try
            {
                T3.Text = (double.Parse(T1.Text) - double.Parse(T2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            try
            {
                T3.Text = (double.Parse(T1.Text) * double.Parse(T2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            try
            {
                T3.Text = (double.Parse(T1.Text) / double.Parse(T2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
