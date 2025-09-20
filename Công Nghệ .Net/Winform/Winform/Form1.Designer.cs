namespace Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            T1 = new TextBox();
            T2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // T1
            // 
            T1.Location = new Point(248, 83);
            T1.Name = "T1";
            T1.Size = new Size(325, 27);
            T1.TabIndex = 1;
            T1.Leave += T1_Leave;
            // 
            // T2
            // 
            T2.Location = new Point(248, 156);
            T2.Name = "T2";
            T2.Size = new Size(325, 27);
            T2.TabIndex = 3;
            T2.TextChanged += T2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 156);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Age:";
            // 
            // B1
            // 
            B1.Location = new Point(161, 245);
            B1.Name = "B1";
            B1.Size = new Size(94, 29);
            B1.TabIndex = 4;
            B1.Text = "Sh&ow";
            B1.UseVisualStyleBackColor = true;
            B1.Click += B1_Click;
            // 
            // B2
            // 
            B2.Location = new Point(315, 245);
            B2.Name = "B2";
            B2.Size = new Size(94, 29);
            B2.TabIndex = 5;
            B2.Text = "&Clear";
            B2.UseVisualStyleBackColor = true;
            B2.Click += B2_Click;
            // 
            // B3
            // 
            B3.Location = new Point(467, 245);
            B3.Name = "B3";
            B3.Size = new Size(94, 29);
            B3.TabIndex = 6;
            B3.Text = "Ex&it";
            B3.UseVisualStyleBackColor = true;
            B3.Click += B3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
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
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T1;
        private TextBox T2;
        private Label label1;
        private Label label2;
        private Button B1;
        private Button B2;
        private Button B3;
        private ErrorProvider errorProvider1;
    }
}
