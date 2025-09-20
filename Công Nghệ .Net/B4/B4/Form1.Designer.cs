namespace B4
{
    partial class Form1
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
            this.T1 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.R1 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.R3 = new System.Windows.Forms.RadioButton();
            this.R4 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.B1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "kq";
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(225, 50);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(100, 20);
            this.T1.TabIndex = 3;
            this.T1.TextChanged += new System.EventHandler(this.T1_TextChanged);
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(446, 50);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(100, 20);
            this.T2.TabIndex = 4;
            this.T2.TextChanged += new System.EventHandler(this.T2_TextChanged);
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(225, 111);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(321, 20);
            this.T3.TabIndex = 5;
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(243, 185);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(31, 17);
            this.R1.TabIndex = 7;
            this.R1.TabStop = true;
            this.R1.Text = "+";
            this.R1.UseVisualStyleBackColor = true;
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(334, 185);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(28, 17);
            this.R2.TabIndex = 8;
            this.R2.TabStop = true;
            this.R2.Text = "-";
            this.R2.UseVisualStyleBackColor = true;
            // 
            // R3
            // 
            this.R3.AutoSize = true;
            this.R3.Location = new System.Drawing.Point(425, 185);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(30, 17);
            this.R3.TabIndex = 8;
            this.R3.TabStop = true;
            this.R3.Text = "x";
            this.R3.UseVisualStyleBackColor = true;
            // 
            // R4
            // 
            this.R4.AutoSize = true;
            this.R4.Location = new System.Drawing.Point(516, 185);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(30, 17);
            this.R4.TabIndex = 8;
            this.R4.TabStop = true;
            this.R4.Text = "/";
            this.R4.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(334, 217);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 9;
            this.B1.Text = "Tinh";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 261);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.R4);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.RadioButton R3;
        private System.Windows.Forms.RadioButton R4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button B1;
    }
}

