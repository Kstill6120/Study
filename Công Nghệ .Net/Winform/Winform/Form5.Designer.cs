namespace Winform
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            T1 = new TextBox();
            label1 = new Label();
            B1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            T2 = new TextBox();
            B2 = new Button();
            B3 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // T1
            // 
            T1.Location = new Point(345, 110);
            T1.Name = "T1";
            T1.Size = new Size(125, 27);
            T1.TabIndex = 0;
            T1.TextChanged += T1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 37);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Đọc Số Thành Chữ";
            // 
            // B1
            // 
            B1.Location = new Point(238, 154);
            B1.Name = "B1";
            B1.Size = new Size(94, 29);
            B1.TabIndex = 2;
            B1.Text = "Thực Hiện";
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 113);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Dãy Số: Từ 1-999";
            // 
            // T2
            // 
            T2.Location = new Point(161, 212);
            T2.Name = "T2";
            T2.Size = new Size(435, 27);
            T2.TabIndex = 0;
            // 
            // B2
            // 
            B2.Location = new Point(361, 154);
            B2.Name = "B2";
            B2.Size = new Size(94, 29);
            B2.TabIndex = 2;
            B2.Text = "Xóa";
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // B3
            // 
            B3.Location = new Point(502, 154);
            B3.Name = "B3";
            B3.Size = new Size(94, 29);
            B3.TabIndex = 2;
            B3.Text = "Thoát";
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(T2);
            Controls.Add(T1);
            Name = "Form5";
            Text = "Đọc Chữ Số";
            FormClosing += Form5_FormClosing;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T1;
        private Label label1;
        private Button B1;
        private ErrorProvider errorProvider1;
        private Button B3;
        private Button B2;
        private Label label2;
        private TextBox T2;
    }
}