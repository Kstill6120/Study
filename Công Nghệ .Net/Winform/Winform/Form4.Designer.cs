namespace Winform
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
            components = new System.ComponentModel.Container();
            T1 = new TextBox();
            label1 = new Label();
            B2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            T2 = new TextBox();
            T3 = new TextBox();
            T4 = new TextBox();
            T5 = new TextBox();
            B3 = new Button();
            B1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // T1
            // 
            T1.Location = new Point(237, 91);
            T1.Name = "T1";
            T1.Size = new Size(64, 27);
            T1.TabIndex = 0;
            T1.TextChanged += T1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 27);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập Dãy Số và Tính Tổng";
            // 
            // B2
            // 
            B2.Location = new Point(207, 298);
            B2.Name = "B2";
            B2.Size = new Size(94, 29);
            B2.TabIndex = 2;
            B2.Text = "Tiếp tục";
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 98);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 149);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "Dãy vừa nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 197);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 1;
            label4.Text = "Tổng các pt trong dãy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 245);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "Tổng Chẵn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 245);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 1;
            label6.Text = "Tổng Lẻ";
            // 
            // T2
            // 
            T2.Location = new Point(276, 142);
            T2.Name = "T2";
            T2.Size = new Size(125, 27);
            T2.TabIndex = 0;
            // 
            // T3
            // 
            T3.Location = new Point(328, 190);
            T3.Name = "T3";
            T3.Size = new Size(125, 27);
            T3.TabIndex = 0;
            // 
            // T4
            // 
            T4.Location = new Point(256, 238);
            T4.Name = "T4";
            T4.Size = new Size(64, 27);
            T4.TabIndex = 0;
            // 
            // T5
            // 
            T5.Location = new Point(396, 238);
            T5.Name = "T5";
            T5.Size = new Size(64, 27);
            T5.TabIndex = 0;
            // 
            // B3
            // 
            B3.Location = new Point(371, 298);
            B3.Name = "B3";
            B3.Size = new Size(94, 29);
            B3.TabIndex = 2;
            B3.Text = "Thoát";
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // B1
            // 
            B1.Location = new Point(312, 89);
            B1.Name = "B1";
            B1.Size = new Size(94, 29);
            B1.TabIndex = 2;
            B1.Text = "Nhập";
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B3);
            Controls.Add(B1);
            Controls.Add(B2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(T5);
            Controls.Add(T4);
            Controls.Add(T3);
            Controls.Add(T2);
            Controls.Add(T1);
            Name = "Form4";
            Text = "Dãy số và Tính Tổng";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T1;
        private Label label1;
        private Button B2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox T2;
        private TextBox T3;
        private TextBox T4;
        private TextBox T5;
        private Button B3;
        private Button B1;
        private ErrorProvider errorProvider1;
    }
}