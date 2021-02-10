namespace Collatz_conjecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.Input.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.Input.Location = new System.Drawing.Point(229, 948);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(726, 57);
            this.Input.TabIndex = 0;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.output.Location = new System.Drawing.Point(237, 1134);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 47);
            this.output.TabIndex = 2;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(51, 1024);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(904, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Processing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Processing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 948);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input :";
            // 
            // OutputValue
            // 
            this.OutputValue.AutoSize = true;
            this.OutputValue.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.OutputValue.Location = new System.Drawing.Point(32, 1124);
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.Size = new System.Drawing.Size(205, 57);
            this.OutputValue.TabIndex = 5;
            this.OutputValue.Text = "Output :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1011, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 57);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(749, 1187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 57);
            this.label4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Collatz_conjecture.Properties.Resources.Collatz_conjecture_PNG_Program2;
            this.pictureBox1.Location = new System.Drawing.Point(75, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(866, 887);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(85)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1047, 1303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collatz conjecture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

