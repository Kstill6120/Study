namespace B4
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R1 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.T3 = new System.Windows.Forms.TextBox();
            this.T4 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giai Phuong Trinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhap b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhap c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "kq";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(299, 146);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(287, 20);
            this.T1.TabIndex = 5;
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(299, 175);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(287, 20);
            this.T2.TabIndex = 5;
            this.T2.TextChanged += new System.EventHandler(this.T2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.R2);
            this.groupBox1.Controls.Add(this.R1);
            this.groupBox1.Location = new System.Drawing.Point(194, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ban vui long chon";
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(50, 19);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(133, 17);
            this.R1.TabIndex = 0;
            this.R1.TabStop = true;
            this.R1.Text = "Phuong trinh bac  nhat";
            this.R1.UseVisualStyleBackColor = true;
            this.R1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(50, 57);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(126, 17);
            this.R2.TabIndex = 1;
            this.R2.TabStop = true;
            this.R2.Text = "Phuong trinh bac  hai";
            this.R2.UseVisualStyleBackColor = true;
            this.R2.CheckedChanged += new System.EventHandler(this.R2_CheckedChanged);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(610, 146);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 7;
            this.B1.Text = "Giai";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(610, 175);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 23);
            this.B2.TabIndex = 8;
            this.B2.Text = "Thoat";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(299, 209);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(287, 20);
            this.T3.TabIndex = 9;
            this.T3.TextChanged += new System.EventHandler(this.T3_TextChanged);
            // 
            // T4
            // 
            this.T4.Location = new System.Drawing.Point(299, 242);
            this.T4.Multiline = true;
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(287, 49);
            this.T4.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 303);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.TextBox T4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}