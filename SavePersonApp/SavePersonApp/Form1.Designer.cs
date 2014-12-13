namespace SavePersonApp
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.ShowingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonsText = new System.Windows.Forms.TextBox();
            this.CountListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(443, 33);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ShowingButton
            // 
            this.ShowingButton.Location = new System.Drawing.Point(472, 79);
            this.ShowingButton.Name = "ShowingButton";
            this.ShowingButton.Size = new System.Drawing.Size(75, 23);
            this.ShowingButton.TabIndex = 1;
            this.ShowingButton.Text = "Show All";
            this.ShowingButton.UseVisualStyleBackColor = true;
            this.ShowingButton.Click += new System.EventHandler(this.ShowingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // PersonsText
            // 
            this.PersonsText.Location = new System.Drawing.Point(161, 36);
            this.PersonsText.Name = "PersonsText";
            this.PersonsText.Size = new System.Drawing.Size(100, 20);
            this.PersonsText.TabIndex = 4;
            // 
            // CountListBox
            // 
            this.CountListBox.FormattingEnabled = true;
            this.CountListBox.Location = new System.Drawing.Point(161, 135);
            this.CountListBox.Name = "CountListBox";
            this.CountListBox.Size = new System.Drawing.Size(160, 225);
            this.CountListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountListBox);
            this.Controls.Add(this.PersonsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowingButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ShowingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonsText;
        private System.Windows.Forms.ListBox CountListBox;
        private System.Windows.Forms.Label label3;
    }
}

