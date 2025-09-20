namespace Winform
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            T1 = new TextBox();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            T2 = new TextBox();
            T3 = new TextBox();
            T4 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 100);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "a=";
            // 
            // T1
            // 
            T1.Location = new Point(295, 93);
            T1.Name = "T1";
            T1.Size = new Size(125, 27);
            T1.TabIndex = 1;
            T1.TextChanged += T1_TextChanged;
            // 
            // B1
            // 
            B1.Location = new Point(184, 289);
            B1.Name = "B1";
            B1.Size = new Size(94, 29);
            B1.TabIndex = 2;
            B1.Text = "Thực Hiện";
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            // 
            // B2
            // 
            B2.Location = new Point(313, 289);
            B2.Name = "B2";
            B2.Size = new Size(94, 29);
            B2.TabIndex = 2;
            B2.Text = "Tiếp Tục";
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // B3
            // 
            B3.Location = new Point(440, 289);
            B3.Name = "B3";
            B3.Size = new Size(94, 29);
            B3.TabIndex = 2;
            B3.Text = "Thoát";
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "USC-BSC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 152);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 0;
            label3.Text = "b=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 198);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 0;
            label4.Text = "USCLN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 243);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 0;
            label5.Text = "BSCNN";
            // 
            // T2
            // 
            T2.Location = new Point(295, 145);
            T2.Name = "T2";
            T2.Size = new Size(125, 27);
            T2.TabIndex = 1;
            T2.TextChanged += T2_TextChanged;
            // 
            // T3
            // 
            T3.Location = new Point(295, 191);
            T3.Name = "T3";
            T3.Size = new Size(125, 27);
            T3.TabIndex = 1;
            // 
            // T4
            // 
            T4.Location = new Point(295, 236);
            T4.Name = "T4";
            T4.Size = new Size(125, 27);
            T4.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(T4);
            Controls.Add(T3);
            Controls.Add(T2);
            Controls.Add(T1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Ước số - Bội số";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox T1;
        private Button B1;
        private Button B2;
        private Button B3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox T2;
        private TextBox T3;
        private TextBox T4;
        private ErrorProvider errorProvider1;
    }
}