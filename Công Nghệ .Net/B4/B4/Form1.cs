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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class TinhToan{
            
            public float a{get; set;}
            public float b{get; set;}
            public TinhToan(){
                a=b=0;
            }
            public TinhToan(float a,float b){
                this.a = a;
                this.b = b;
            }
            public float Cong() { return a + b; }
            public float Tru() { return a - b; }
            public float Nhan() { return a * b; }
            public float Chia() { return a / b; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
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
            if (!T1.Text.All(char.IsDigit))
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
            string s = "Kết quả là: \n";
            float a = float.Parse(T1.Text);
            float b = float.Parse(T2.Text);
            TinhToan dt = new TinhToan(a, b);
            if (R1.Checked)
            {
             T3.Text=dt.Cong().ToString();
                MessageBox.Show(s + a + "+" + b + " = " + dt.Cong());
            }
               
            else if (R2.Checked){
                T3.Text = dt.Tru().ToString();
                MessageBox.Show(s + a + "-" + b + " = " + dt.Tru());
            }

            else if (R3.Checked)
            {
                T3.Text = dt.Nhan().ToString();
                MessageBox.Show(s + a + "*" + b + " = " + dt.Nhan());
            }

            else if (b != 0)
            {
                T3.Text = dt.Chia().ToString();
                MessageBox.Show(s + a + "/" + b + " = " +
                dt.Chia());
            }

            else
                MessageBox.Show("Phép chia bị lỗi!");
        }
    }
}
