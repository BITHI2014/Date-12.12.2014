using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = CustomerNameText.Text;
            double number =Convert.ToDouble (TicketNumberText.Text);
            Double result = number*10;
            MessageBox.Show(name+ ", You Have To Paid  " +  result+"Taka");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = CustomerNameText.Text;
            double number = Convert.ToDouble(TicketNumberText.Text);
            double result = number*10;
            MessageBox.Show("name:" + name + "\nnumber:10Taka\nTotal Price: " + result);
        }


    }
}
