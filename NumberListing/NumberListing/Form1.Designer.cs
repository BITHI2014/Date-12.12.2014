namespace NumberListing
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
            this.Checking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListBox();
            this.numbersText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Checking
            // 
            this.Checking.Location = new System.Drawing.Point(361, 54);
            this.Checking.Name = "Checking";
            this.Checking.Size = new System.Drawing.Size(75, 23);
            this.Checking.TabIndex = 0;
            this.Checking.Text = "Add";
            this.Checking.UseVisualStyleBackColor = true;
            this.Checking.Click += new System.EventHandler(this.Checking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.Location = new System.Drawing.Point(170, 126);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(218, 186);
            this.resultList.TabIndex = 2;
            // 
            // numbersText
            // 
            this.numbersText.Location = new System.Drawing.Point(153, 51);
            this.numbersText.Name = "numbersText";
            this.numbersText.Size = new System.Drawing.Size(100, 20);
            this.numbersText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 406);
            this.Controls.Add(this.numbersText);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Checking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Checking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.TextBox numbersText;
    }
}

