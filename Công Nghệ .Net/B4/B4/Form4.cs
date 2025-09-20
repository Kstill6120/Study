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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public class MangSoNguyen
        {
            private int[] arr;
            public int[] Arr
            {
                get {return arr; }
                set { arr = value ?? new int[0]; }
            }

            public MangSoNguyen()
            {
                arr = new int[0];
            }

            public MangSoNguyen(int[] arr)
            {
                Arr = arr ?? new int[0];
            }
            public void SapXepTang()
            {
                Array.Sort(arr);
            }
            public void SapXepGiam()
            {
                Array.Sort(arr);
                Array.Reverse(arr);
            }
            public int TimViTri(int value)
            {
                return Array.IndexOf(arr, value);
            }
            public int TimGiaTriTaiViTri(int index)
            {
                if (index < 0 || index >= arr.Length) throw new IndexOutOfRangeException();
                return arr[index];
            }
            public void Them(int value, int index)
            {
                if (index < 0 || index > arr.Length) throw new IndexOutOfRangeException();

                int[] newArr = new int[arr.Length + 1];
                for (int i = 0; i < index; i++)
                    newArr[i] = arr[i];
                newArr[index] = value;
                for (int i = index; i < arr.Length; i++)
                    newArr[i + 1] = arr[i];
                arr = newArr;
            }
            public void XoaTaiViTri(int index)
            {
                if (index < 0 || index >= arr.Length) throw new IndexOutOfRangeException();

                int[] newArr = new int[arr.Length - 1];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (i == index) continue;
                    newArr[j++] = arr[i];
                }
                arr = newArr;
            }
            public bool XoaTheoGiaTri(int value)
            {
                int idx = TimViTri(value);
                if (idx == -1) return false;
                XoaTaiViTri(idx);
                return true;
            }
            public int Tong() => arr.Sum();
            public int TongChan() => arr.Where(x => x % 2 == 0).Sum();
            public int TongLe() => arr.Where(x => x % 2 != 0).Sum();
            public int Max() => arr.Length == 0 ? 0 : arr.Max();
            public int Min() => arr.Length == 0 ? 0 : arr.Min();
            public void ThayThe(int index, int newValue)
            {
                if (index < 0 || index >= arr.Length) throw new IndexOutOfRangeException();
                arr[index] = newValue;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TKQ.Enabled=false;
            TSotimduoc.Enabled=false;
            TTongchan.Enabled=false;
            TTongle.Enabled=false;
            TTongmang.Enabled=false;
            TMax.Enabled = false;
            TMin.Enabled = false;
        }
        MangSoNguyen mang = new MangSoNguyen();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r= MessageBox.Show("Bạn có muốn thoát","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BTong_Click(object sender, EventArgs e)
        {

        }

        private void BNhapmang_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = TNhapmang.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                mang.Arr=arr;
                HienThiMang();
            }
            catch
            {
                MessageBox.Show("Nhập sai định dạng, chỉ nhập số nguyên cách nhau bởi dấu cách hoặc dấu phẩy!");
            }
        }
        private void HienThiMang()
        {
            TKQ.Text = string.Join(" ", mang.Arr);
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            TNhapmang.Clear();
            TKQ.Clear();
        }

        private void BThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BThucHien_Click(object sender, EventArgs e)
        {
            if(RBTang.Checked)
            {
                mang.SapXepTang();  
            }
            if (RBGiam.Checked)
            {
                mang.SapXepGiam();
            }
            HienThiMang();
        }

        private void TNhapmang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
