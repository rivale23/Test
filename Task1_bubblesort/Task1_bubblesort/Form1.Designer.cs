namespace Task1_bubblesort
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
            this.button1 = new System.Windows.Forms.Button();
            this.TBinput = new System.Windows.Forms.TextBox();
            this.TBoutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBinput
            // 
            this.TBinput.Location = new System.Drawing.Point(55, 52);
            this.TBinput.Multiline = true;
            this.TBinput.Name = "TBinput";
            this.TBinput.Size = new System.Drawing.Size(423, 83);
            this.TBinput.TabIndex = 1;
            this.TBinput.Text = "17, 3, 30, 41, 24, 35, 50, 12";
            // 
            // TBoutput
            // 
            this.TBoutput.Location = new System.Drawing.Point(55, 181);
            this.TBoutput.Multiline = true;
            this.TBoutput.Name = "TBoutput";
            this.TBoutput.ReadOnly = true;
            this.TBoutput.Size = new System.Drawing.Size(423, 84);
            this.TBoutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write the numbers separated by comma, e.g.: 1,2,3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorted array:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoutput);
            this.Controls.Add(this.TBinput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Bubble Algorithm                   Ricardo Vasquez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBinput;
        private System.Windows.Forms.TextBox TBoutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

