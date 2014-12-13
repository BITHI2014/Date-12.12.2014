namespace PurchaseTicketApp
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
            this.TicketNumberText = new System.Windows.Forms.TextBox();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicketNumberText
            // 
            this.TicketNumberText.Location = new System.Drawing.Point(198, 91);
            this.TicketNumberText.Name = "TicketNumberText";
            this.TicketNumberText.Size = new System.Drawing.Size(100, 20);
            this.TicketNumberText.TabIndex = 15;
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Location = new System.Drawing.Point(198, 31);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameText.TabIndex = 14;
            this.CustomerNameText.Text = "B";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(259, 197);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 13);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "One Ticket 10 Taka";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(89, 38);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Customer Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(89, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Number Of Ticket";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, -21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Customer & Ticket information";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(352, 254);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "Details";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(181, 254);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Total Price";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 354);
            this.Controls.Add(this.TicketNumberText);
            this.Controls.Add(this.CustomerNameText);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TicketNumberText;
        internal System.Windows.Forms.TextBox CustomerNameText;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
    }
}

