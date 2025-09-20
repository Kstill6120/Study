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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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
        static int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a); // luôn trả về số dương
        }

        // Hàm tính BSCNN (LCM)
        static int BSCNN(int a, int b)
        {
            return Math.Abs(a * b) / USCLN(a, b);
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

        private void T2_TextChanged(object sender, EventArgs e)
        {
            Control T2 = (Control)sender;
            if (!T2.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T2, "Nhập sai số");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(T1.Text)|| string.IsNullOrWhiteSpace(T2.Text))
            {
                MessageBox.Show("Nhập sai","Sai",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            int a = int.Parse(T1.Text);
            int b = int.Parse(T2.Text);
            T3.Text = USCLN(a, b).ToString();
            T4.Text = BSCNN(a, b).ToString();
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            T3.Enabled = false;
            T4.Enabled = false;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            T1.Clear();
            T2.Clear();
            T3.Clear();
            T4.Clear();
            T1.Focus();
        }
    }
}
