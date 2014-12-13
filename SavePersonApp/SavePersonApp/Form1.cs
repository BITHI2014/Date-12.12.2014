using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavePersonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] names = new string[10];
        public int counterValue = 0;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(PersonsText.Text);
             counterValue = Convert.ToInt32(label3.Text);

            if (counterValue < 10) 
            {
                names[counterValue] = PersonsText.Text;
                counterValue++;
                label3.Text = Convert.ToString(counterValue);
            }

        else
            {
                MessageBox.Show("Names Greater Than 10");
            }
            CountListBox.Items.Clear();
            if (counterValue == 10)
            {
                for (int i = 0; i < counterValue; i++)
                {
                      CountListBox.Items.Add(names[i]);
                }

               
            }
        }

        private void ShowingButton_Click(object sender, EventArgs e)
        {
      /*  CountListBox.Items.Clear();
            for (int i = 0; i <counterValue; i++)

            {
                CountListBox.Items.Add(names[i]);
            }*/
        }

    }


}       