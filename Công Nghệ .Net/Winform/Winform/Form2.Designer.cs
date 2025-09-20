namespace Winform
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            T2 = new TextBox();
            B2 = new Button();
            B3 = new Button();
            B4 = new Button();
            T3 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 133);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "a=";
            // 
            // T1
            // 
            T1.Location = new Point(257, 130);
            T1.Name = "T1";
            T1.Size = new Size(125, 27);
            T1.TabIndex = 1;
            T1.TextChanged += T1_TextChanged;
            // 
            // B1
            // 
            B1.Location = new Point(183, 271);
            B1.Name = "B1";
            B1.Size = new Size(94, 29);
            B1.TabIndex = 6;
            B1.Text = "+";
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 133);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 2;
            label2.Text = "b=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 190);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "kq=";
            // 
            // T2
            // 
            T2.Location = new Point(454, 130);
            T2.Name = "T2";
            T2.Size = new Size(125, 27);
            T2.TabIndex = 3;
            T2.TextChanged += T2_TextChanged;
            // 
            // B2
            // 
            B2.Location = new Point(320, 271);
            B2.Name = "B2";
            B2.Size = new Size(94, 29);
            B2.TabIndex = 7;
            B2.Text = "-";
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // B3
            // 
            B3.Location = new Point(454, 271);
            B3.Name = "B3";
            B3.Size = new Size(94, 29);
            B3.TabIndex = 8;
            B3.Text = "x";
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // B4
            // 
            B4.Location = new Point(590, 271);
            B4.Name = "B4";
            B4.Size = new Size(94, 29);
            B4.TabIndex = 9;
            B4.Text = "/";
            B4.UseVisualStyleBackColor = true;
            B4.Click += B4_Click;
            // 
            // T3
            // 
            T3.Location = new Point(257, 190);
            T3.Name = "T3";
            T3.Size = new Size(322, 27);
            T3.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(B4);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(T2);
            Controls.Add(T3);
            Controls.Add(T1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Cộng Trừ Nhân Chia";
            FormClosing += Form2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox T1;
        private Button B1;
        private Label label2;
        private Label label3;
        private TextBox T2;
        private Button B2;
        private Button B3;
        private Button B4;
        private TextBox T3;
        private ErrorProvider errorProvider1;
    }
}