namespace CountVowles
{
    partial class windowMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEntry = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtCountAns = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a paragraph of text. All vowels, upper and";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "lowercase will be counted. Y is not considered a vowel.";
            // 
            // txtBoxEntry
            // 
            this.txtBoxEntry.Location = new System.Drawing.Point(15, 70);
            this.txtBoxEntry.Multiline = true;
            this.txtBoxEntry.Name = "txtBoxEntry";
            this.txtBoxEntry.Size = new System.Drawing.Size(352, 178);
            this.txtBoxEntry.TabIndex = 2;
            this.txtBoxEntry.TextChanged += new System.EventHandler(this.txtBoxEntry_TextChanged);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(15, 267);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(104, 39);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtCountAns
            // 
            this.txtCountAns.Location = new System.Drawing.Point(125, 275);
            this.txtCountAns.Name = "txtCountAns";
            this.txtCountAns.ReadOnly = true;
            this.txtCountAns.Size = new System.Drawing.Size(63, 22);
            this.txtCountAns.TabIndex = 4;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(194, 280);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 17);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "vowels";
            // 
            // windowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 361);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtCountAns);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtBoxEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "windowMain";
            this.Text = "Count Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEntry;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtCountAns;
        private System.Windows.Forms.Label lblCount;
    }
}

