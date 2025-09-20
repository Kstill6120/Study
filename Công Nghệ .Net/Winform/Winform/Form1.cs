namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            if (string.IsNullOrWhiteSpace(T1.Text) || T1.Text.Length > 10)
            {
                MessageBox.Show("Bạn phải nhập tên!", "Sai tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                T1.Focus();
                return; // Dừng lại, không chạy tiếp
            }
            if (!int.TryParse(T2.Text, out int year) || year < 1900)
            {
                MessageBox.Show("Bạn phải nhập năm sinh hợp lệ (>=1900)!", "Sai tuổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                T2.Focus();
                return;
            }
            s = "Your name is: " + T1.Text + "\n";
            age = DateTime.Now.Year - int.Parse(T2.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);

        }

        private void B2_Click(object sender, EventArgs e)
        {
            T1.Clear();
            T2.Clear();
            T1.Focus();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void T1_Leave(object sender, EventArgs e)
        {
            Control T1 = (Control)sender;
            if (T1.Text.Trim().Length == 0 || T1.Text.Length > 10)
            {
                this.errorProvider1.SetError(T1, "Ko được bỏ trống và <10 ki tu");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void T2_TextChanged(object sender, EventArgs e)
        {
            Control T2 = (Control)sender;
            int value;
            if (T2.Text.Length > 0 && !T2.Text.All(char.IsDigit))
            {
                this.errorProvider1.SetError(T2, "Nhập sai số");
            }
            else if (!int.TryParse(T2.Text, out value))
            {
                this.errorProvider1.SetError(T2, "Nhập sai số");
            }
            else if (value < 1900 || value > DateTime.Now.Year)
            {
                this.errorProvider1.SetError(T2, "Số >1900 và < Year Now");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
