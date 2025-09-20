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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            T2.Enabled = false;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            int n=int.Parse(T1.Text);
            if(string.IsNullOrEmpty(T1.Text)||!int.TryParse(T1.Text,out n)||n<0||n>999)
            {
                MessageBox.Show("Nhập sai", "Sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                T1.Focus();
            }

            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int dv = n % 10;
            T2.Text=(Tram(tram)+Chuc(tram,chuc,dv)+Donvi(tram,chuc,dv)).Trim();
    

        }
        private string Tram(int n)
        {
            switch (n)
            {
                case 1: return "Một Trăm ";
                case 2: return "Hai Trăm ";
                case 3: return "Ba Trăm ";
                case 4: return "Bốn Trăm ";
                case 5: return "Năm Trăm ";
                case 6: return "Sáu Trăm ";
                case 7: return "Bảy Trăm ";
                case 8: return "Tám Trăm ";
                case 9: return "Chín Trăm ";
                default: return "";
            }
        }
        private string Chuc(int tram,int n,int donvi)
        {
            switch (n)
            {
                case 0: if (tram != 0&&donvi!=0) return "Linh ";
                    return "";
                case 1: return "Mười ";
                case 2: return "Hai Mươi ";
                case 3: return "Ba Mươi ";
                case 4: return "Bốn Mươi ";
                case 5: return "Năm Mươi ";
                case 6: return "Sáu Mươi ";
                case 7: return "Bảy Mươi ";
                case 8: return "Tám Mươi ";
                case 9: return "Chín Mươi ";
                default: return "";
            }
        }
        private string Donvi(int tram,int chuc,int n)
        {
            switch (n)
            {
                case 0: if (chuc != 0||tram!=0) return "";
                    else return "Không";
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: if (chuc>0) return "Lăm";
                    else return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                case 9: return "Chín";
                default: return "";
            }
        }
        private void B2_Click(object sender, EventArgs e)
        {
            T1.ResetText();
            T2.ResetText();
            T1.Focus();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void T1_TextChanged(object sender, EventArgs e)
        {
            Control T1 = (Control)sender;
            int value=0;
            if(string.IsNullOrEmpty(T1.Text))
            {
                this.errorProvider1.SetError(T1, "ko dc bỏ trống");
            }
            else if (!T1.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T1, "Chỉ đc nhập số");
            }else if (int.TryParse(T1.Text,out value))
            {
                if(value <0 || value > 999)
                {
                    this.errorProvider1.SetError(T1, "Số 0-999");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }
    }
}
