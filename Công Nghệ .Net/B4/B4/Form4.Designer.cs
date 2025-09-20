namespace B4
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BThucHien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBGiatricantim = new System.Windows.Forms.RadioButton();
            this.TSotimduoc = new System.Windows.Forms.TextBox();
            this.TVitricantim = new System.Windows.Forms.TextBox();
            this.TGiatricantim = new System.Windows.Forms.TextBox();
            this.RBVitricantim = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TNhapmang = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.RBGiatricanxoa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RBVitricanxoa = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RBGiatricanthem = new System.Windows.Forms.RadioButton();
            this.TGiatricanthem = new System.Windows.Forms.TextBox();
            this.TVitricanthem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TTongmang = new System.Windows.Forms.TextBox();
            this.TTongle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TTongchan = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TMax = new System.Windows.Forms.TextBox();
            this.TMin = new System.Windows.Forms.TextBox();
            this.BTim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RBGiatricanthaythe = new System.Windows.Forms.RadioButton();
            this.TGiatricanthaythe = new System.Windows.Forms.TextBox();
            this.RBVitricanthaythe = new System.Windows.Forms.RadioButton();
            this.TSothaythela = new System.Windows.Forms.TextBox();
            this.TVitricanthaythe = new System.Windows.Forms.TextBox();
            this.TKQ = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.RBGiam = new System.Windows.Forms.RadioButton();
            this.RBTang = new System.Windows.Forms.RadioButton();
            this.BReset = new System.Windows.Forms.Button();
            this.BThoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BNhapmang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BThucHien
            // 
            this.BThucHien.Location = new System.Drawing.Point(11, 66);
            this.BThucHien.Margin = new System.Windows.Forms.Padding(4);
            this.BThucHien.Name = "BThucHien";
            this.BThucHien.Size = new System.Drawing.Size(133, 64);
            this.BThucHien.TabIndex = 1;
            this.BThucHien.Text = "Thực Hiện";
            this.BThucHien.UseVisualStyleBackColor = true;
            this.BThucHien.Click += new System.EventHandler(this.BThucHien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBGiatricantim);
            this.groupBox1.Controls.Add(this.TSotimduoc);
            this.groupBox1.Controls.Add(this.TVitricantim);
            this.groupBox1.Controls.Add(this.TGiatricantim);
            this.groupBox1.Controls.Add(this.RBVitricantim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // RBGiatricantim
            // 
            this.RBGiatricantim.AutoSize = true;
            this.RBGiatricantim.Location = new System.Drawing.Point(8, 37);
            this.RBGiatricantim.Margin = new System.Windows.Forms.Padding(4);
            this.RBGiatricantim.Name = "RBGiatricantim";
            this.RBGiatricantim.Size = new System.Drawing.Size(131, 20);
            this.RBGiatricantim.TabIndex = 1;
            this.RBGiatricantim.TabStop = true;
            this.RBGiatricantim.Text = "Tìm giá trị cần tìm";
            this.RBGiatricantim.UseVisualStyleBackColor = true;
            this.RBGiatricantim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TSotimduoc
            // 
            this.TSotimduoc.Location = new System.Drawing.Point(153, 91);
            this.TSotimduoc.Margin = new System.Windows.Forms.Padding(4);
            this.TSotimduoc.Name = "TSotimduoc";
            this.TSotimduoc.Size = new System.Drawing.Size(31, 22);
            this.TSotimduoc.TabIndex = 0;
            this.TSotimduoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TVitricantim
            // 
            this.TVitricantim.Location = new System.Drawing.Point(153, 64);
            this.TVitricantim.Margin = new System.Windows.Forms.Padding(4);
            this.TVitricantim.Name = "TVitricantim";
            this.TVitricantim.Size = new System.Drawing.Size(31, 22);
            this.TVitricantim.TabIndex = 0;
            this.TVitricantim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TGiatricantim
            // 
            this.TGiatricantim.Location = new System.Drawing.Point(153, 37);
            this.TGiatricantim.Margin = new System.Windows.Forms.Padding(4);
            this.TGiatricantim.Name = "TGiatricantim";
            this.TGiatricantim.Size = new System.Drawing.Size(31, 22);
            this.TGiatricantim.TabIndex = 0;
            this.TGiatricantim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RBVitricantim
            // 
            this.RBVitricantim.AutoSize = true;
            this.RBVitricantim.Location = new System.Drawing.Point(8, 65);
            this.RBVitricantim.Margin = new System.Windows.Forms.Padding(4);
            this.RBVitricantim.Name = "RBVitricantim";
            this.RBVitricantim.Size = new System.Drawing.Size(122, 20);
            this.RBVitricantim.TabIndex = 1;
            this.RBVitricantim.TabStop = true;
            this.RBVitricantim.Text = "Tìm vị trí cần tìm";
            this.RBVitricantim.UseVisualStyleBackColor = true;
            this.RBVitricantim.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sô tim được là:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TNhapmang
            // 
            this.TNhapmang.Location = new System.Drawing.Point(152, 10);
            this.TNhapmang.Margin = new System.Windows.Forms.Padding(4);
            this.TNhapmang.Name = "TNhapmang";
            this.TNhapmang.Size = new System.Drawing.Size(283, 22);
            this.TNhapmang.TabIndex = 0;
            this.TNhapmang.TextChanged += new System.EventHandler(this.TNhapmang_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.RBGiatricanxoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RBVitricanxoa);
            this.groupBox2.Location = new System.Drawing.Point(307, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(169, 35);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(31, 22);
            this.textBox19.TabIndex = 0;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(168, 63);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(31, 22);
            this.textBox18.TabIndex = 0;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RBGiatricanxoa
            // 
            this.RBGiatricanxoa.AutoSize = true;
            this.RBGiatricanxoa.Location = new System.Drawing.Point(33, 37);
            this.RBGiatricanxoa.Margin = new System.Windows.Forms.Padding(4);
            this.RBGiatricanxoa.Name = "RBGiatricanxoa";
            this.RBGiatricanxoa.Size = new System.Drawing.Size(136, 20);
            this.RBGiatricanxoa.TabIndex = 1;
            this.RBGiatricanxoa.TabStop = true;
            this.RBGiatricanxoa.Text = "Tim giá trị cần xóa";
            this.RBGiatricanxoa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cần sắp xếp tăng";
            // 
            // RBVitricanxoa
            // 
            this.RBVitricanxoa.AutoSize = true;
            this.RBVitricanxoa.Location = new System.Drawing.Point(33, 65);
            this.RBVitricanxoa.Margin = new System.Windows.Forms.Padding(4);
            this.RBVitricanxoa.Name = "RBVitricanxoa";
            this.RBVitricanxoa.Size = new System.Drawing.Size(127, 20);
            this.RBVitricanxoa.TabIndex = 1;
            this.RBVitricanxoa.TabStop = true;
            this.RBVitricanxoa.Text = "Tìm vị trí cần xóa";
            this.RBVitricanxoa.UseVisualStyleBackColor = true;
            this.RBVitricanxoa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBGiatricanthem);
            this.groupBox3.Controls.Add(this.TGiatricanthem);
            this.groupBox3.Controls.Add(this.TVitricanthem);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(11, 268);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm";
            // 
            // RBGiatricanthem
            // 
            this.RBGiatricanthem.AutoSize = true;
            this.RBGiatricanthem.Location = new System.Drawing.Point(8, 22);
            this.RBGiatricanthem.Margin = new System.Windows.Forms.Padding(4);
            this.RBGiatricanthem.Name = "RBGiatricanthem";
            this.RBGiatricanthem.Size = new System.Drawing.Size(143, 20);
            this.RBGiatricanthem.TabIndex = 1;
            this.RBGiatricanthem.TabStop = true;
            this.RBGiatricanthem.Text = "Tìm giá trị cần thêm";
            this.RBGiatricanthem.UseVisualStyleBackColor = true;
            // 
            // TGiatricanthem
            // 
            this.TGiatricanthem.Location = new System.Drawing.Point(153, 23);
            this.TGiatricanthem.Margin = new System.Windows.Forms.Padding(4);
            this.TGiatricanthem.Name = "TGiatricanthem";
            this.TGiatricanthem.Size = new System.Drawing.Size(31, 22);
            this.TGiatricanthem.TabIndex = 0;
            this.TGiatricanthem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TVitricanthem
            // 
            this.TVitricanthem.Location = new System.Drawing.Point(153, 50);
            this.TVitricanthem.Margin = new System.Windows.Forms.Padding(4);
            this.TVitricanthem.Name = "TVitricanthem";
            this.TVitricanthem.Size = new System.Drawing.Size(31, 22);
            this.TVitricanthem.TabIndex = 0;
            this.TVitricanthem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "TÌm vị trí cần thêm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cần sắp xếp tăng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TTongmang);
            this.groupBox4.Controls.Add(this.TTongle);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BTong);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TTongchan);
            this.groupBox4.Location = new System.Drawing.Point(307, 268);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng";
            // 
            // TTongmang
            // 
            this.TTongmang.Location = new System.Drawing.Point(137, 23);
            this.TTongmang.Margin = new System.Windows.Forms.Padding(4);
            this.TTongmang.Name = "TTongmang";
            this.TTongmang.Size = new System.Drawing.Size(60, 22);
            this.TTongmang.TabIndex = 0;
            this.TTongmang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TTongle
            // 
            this.TTongle.Location = new System.Drawing.Point(137, 78);
            this.TTongle.Margin = new System.Windows.Forms.Padding(4);
            this.TTongle.Name = "TTongle";
            this.TTongle.Size = new System.Drawing.Size(60, 22);
            this.TTongle.TabIndex = 0;
            this.TTongle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng lẻ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng chẵn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BTong
            // 
            this.BTong.Location = new System.Drawing.Point(208, 22);
            this.BTong.Margin = new System.Windows.Forms.Padding(4);
            this.BTong.Name = "BTong";
            this.BTong.Size = new System.Drawing.Size(51, 79);
            this.BTong.TabIndex = 1;
            this.BTong.Text = "Tổng";
            this.BTong.UseVisualStyleBackColor = true;
            this.BTong.Click += new System.EventHandler(this.BTong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng mảng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TTongchan
            // 
            this.TTongchan.Location = new System.Drawing.Point(137, 50);
            this.TTongchan.Margin = new System.Windows.Forms.Padding(4);
            this.TTongchan.Name = "TTongchan";
            this.TTongchan.Size = new System.Drawing.Size(60, 22);
            this.TTongchan.TabIndex = 0;
            this.TTongchan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TMax);
            this.groupBox5.Controls.Add(this.TMin);
            this.groupBox5.Controls.Add(this.BTim);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(11, 399);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(267, 123);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Max-Min";
            // 
            // TMax
            // 
            this.TMax.Location = new System.Drawing.Point(141, 36);
            this.TMax.Margin = new System.Windows.Forms.Padding(4);
            this.TMax.Name = "TMax";
            this.TMax.Size = new System.Drawing.Size(43, 22);
            this.TMax.TabIndex = 0;
            this.TMax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TMin
            // 
            this.TMin.Location = new System.Drawing.Point(141, 63);
            this.TMin.Margin = new System.Windows.Forms.Padding(4);
            this.TMin.Name = "TMin";
            this.TMin.Size = new System.Drawing.Size(43, 22);
            this.TMin.TabIndex = 0;
            this.TMin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTim
            // 
            this.BTim.Location = new System.Drawing.Point(215, 23);
            this.BTim.Margin = new System.Windows.Forms.Padding(4);
            this.BTim.Name = "BTim";
            this.BTim.Size = new System.Drawing.Size(44, 79);
            this.BTim.TabIndex = 1;
            this.BTim.Text = "Tìm";
            this.BTim.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá trị nhỏ nhất";
            this.label11.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giá trị lớn nhất";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RBGiatricanthaythe);
            this.groupBox6.Controls.Add(this.TGiatricanthaythe);
            this.groupBox6.Controls.Add(this.RBVitricanthaythe);
            this.groupBox6.Controls.Add(this.TSothaythela);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.TVitricanthaythe);
            this.groupBox6.Location = new System.Drawing.Point(307, 399);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(267, 123);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thay Thế";
            // 
            // RBGiatricanthaythe
            // 
            this.RBGiatricanthaythe.AutoSize = true;
            this.RBGiatricanthaythe.Location = new System.Drawing.Point(69, 25);
            this.RBGiatricanthaythe.Margin = new System.Windows.Forms.Padding(4);
            this.RBGiatricanthaythe.Name = "RBGiatricanthaythe";
            this.RBGiatricanthaythe.Size = new System.Drawing.Size(136, 20);
            this.RBGiatricanthaythe.TabIndex = 1;
            this.RBGiatricanthaythe.TabStop = true;
            this.RBGiatricanthaythe.Text = "Giá trị cần thay thế";
            this.RBGiatricanthaythe.UseVisualStyleBackColor = true;
            // 
            // TGiatricanthaythe
            // 
            this.TGiatricanthaythe.Location = new System.Drawing.Point(208, 23);
            this.TGiatricanthaythe.Margin = new System.Windows.Forms.Padding(4);
            this.TGiatricanthaythe.Name = "TGiatricanthaythe";
            this.TGiatricanthaythe.Size = new System.Drawing.Size(31, 22);
            this.TGiatricanthaythe.TabIndex = 0;
            this.TGiatricanthaythe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RBVitricanthaythe
            // 
            this.RBVitricanthaythe.AutoSize = true;
            this.RBVitricanthaythe.Location = new System.Drawing.Point(69, 53);
            this.RBVitricanthaythe.Margin = new System.Windows.Forms.Padding(4);
            this.RBVitricanthaythe.Name = "RBVitricanthaythe";
            this.RBVitricanthaythe.Size = new System.Drawing.Size(127, 20);
            this.RBVitricanthaythe.TabIndex = 1;
            this.RBVitricanthaythe.TabStop = true;
            this.RBVitricanthaythe.Text = "Vị trí cần thay thế";
            this.RBVitricanthaythe.UseVisualStyleBackColor = true;
            this.RBVitricanthaythe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TSothaythela
            // 
            this.TSothaythela.Location = new System.Drawing.Point(208, 78);
            this.TSothaythela.Margin = new System.Windows.Forms.Padding(4);
            this.TSothaythela.Name = "TSothaythela";
            this.TSothaythela.Size = new System.Drawing.Size(31, 22);
            this.TSothaythela.TabIndex = 0;
            this.TSothaythela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TVitricanthaythe
            // 
            this.TVitricanthaythe.Location = new System.Drawing.Point(208, 50);
            this.TVitricanthaythe.Margin = new System.Windows.Forms.Padding(4);
            this.TVitricanthaythe.Name = "TVitricanthaythe";
            this.TVitricanthaythe.Size = new System.Drawing.Size(31, 22);
            this.TVitricanthaythe.TabIndex = 0;
            this.TVitricanthaythe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TKQ
            // 
            this.TKQ.Location = new System.Drawing.Point(152, 42);
            this.TKQ.Margin = new System.Windows.Forms.Padding(4);
            this.TKQ.Name = "TKQ";
            this.TKQ.Size = new System.Drawing.Size(283, 22);
            this.TKQ.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.RBGiam);
            this.groupBox7.Controls.Add(this.RBTang);
            this.groupBox7.Location = new System.Drawing.Point(203, 81);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(371, 49);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sắp Xếp";
            // 
            // RBGiam
            // 
            this.RBGiam.AutoSize = true;
            this.RBGiam.Location = new System.Drawing.Point(189, 21);
            this.RBGiam.Margin = new System.Windows.Forms.Padding(4);
            this.RBGiam.Name = "RBGiam";
            this.RBGiam.Size = new System.Drawing.Size(115, 20);
            this.RBGiam.TabIndex = 1;
            this.RBGiam.TabStop = true;
            this.RBGiam.Text = "Sắp Xếp Giảm";
            this.RBGiam.UseVisualStyleBackColor = true;
            // 
            // RBTang
            // 
            this.RBTang.AutoSize = true;
            this.RBTang.Location = new System.Drawing.Point(23, 21);
            this.RBTang.Margin = new System.Windows.Forms.Padding(4);
            this.RBTang.Name = "RBTang";
            this.RBTang.Size = new System.Drawing.Size(115, 20);
            this.RBTang.TabIndex = 1;
            this.RBTang.TabStop = true;
            this.RBTang.Text = "Sắp Xếp Tăng";
            this.RBTang.UseVisualStyleBackColor = true;
            // 
            // BReset
            // 
            this.BReset.Location = new System.Drawing.Point(444, 10);
            this.BReset.Margin = new System.Windows.Forms.Padding(4);
            this.BReset.Name = "BReset";
            this.BReset.Size = new System.Drawing.Size(73, 25);
            this.BReset.TabIndex = 1;
            this.BReset.Text = "Reset";
            this.BReset.UseVisualStyleBackColor = true;
            this.BReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // BThoat
            // 
            this.BThoat.Location = new System.Drawing.Point(444, 41);
            this.BThoat.Margin = new System.Windows.Forms.Padding(4);
            this.BThoat.Name = "BThoat";
            this.BThoat.Size = new System.Drawing.Size(73, 25);
            this.BThoat.TabIndex = 1;
            this.BThoat.Text = "Thoát";
            this.BThoat.UseVisualStyleBackColor = true;
            this.BThoat.Click += new System.EventHandler(this.BThoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "KQ:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // BNhapmang
            // 
            this.BNhapmang.Location = new System.Drawing.Point(31, 7);
            this.BNhapmang.Margin = new System.Windows.Forms.Padding(4);
            this.BNhapmang.Name = "BNhapmang";
            this.BNhapmang.Size = new System.Drawing.Size(111, 25);
            this.BNhapmang.TabIndex = 1;
            this.BNhapmang.Text = "Nhập Mảng";
            this.BNhapmang.UseVisualStyleBackColor = true;
            this.BNhapmang.Click += new System.EventHandler(this.BNhapmang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thay thế là";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 529);
            this.Controls.Add(this.TKQ);
            this.Controls.Add(this.TNhapmang);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BThoat);
            this.Controls.Add(this.BNhapmang);
            this.Controls.Add(this.BReset);
            this.Controls.Add(this.BThucHien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TNhapmang;
        private System.Windows.Forms.RadioButton RBVitricantim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TKQ;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton RBGiatricantim;
        private System.Windows.Forms.RadioButton RBGiam;
        private System.Windows.Forms.RadioButton RBTang;
        private System.Windows.Forms.Button BReset;
        private System.Windows.Forms.TextBox TSotimduoc;
        private System.Windows.Forms.TextBox TVitricantim;
        private System.Windows.Forms.TextBox TGiatricantim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBGiatricanthaythe;
        private System.Windows.Forms.TextBox TGiatricanthaythe;
        private System.Windows.Forms.RadioButton RBVitricanthaythe;
        private System.Windows.Forms.TextBox TSothaythela;
        private System.Windows.Forms.TextBox TVitricanthaythe;
        private System.Windows.Forms.TextBox TTongmang;
        private System.Windows.Forms.TextBox TTongle;
        private System.Windows.Forms.Button BTong;
        private System.Windows.Forms.TextBox TTongchan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TMax;
        private System.Windows.Forms.TextBox TMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTim;
        private System.Windows.Forms.TextBox TGiatricanthem;
        private System.Windows.Forms.TextBox TVitricanthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BThoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.RadioButton RBGiatricanxoa;
        private System.Windows.Forms.RadioButton RBVitricanxoa;
        private System.Windows.Forms.RadioButton RBGiatricanthem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BNhapmang;
        private System.Windows.Forms.Label label1;
    }
}