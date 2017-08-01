using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Rosa Munguia
 * StudentID: 300735300
 * Date: August 1 2017
 * Description: Demo application to showcase windows fors and UI controls
 * Version- 0.1 Project created
 * */
namespace Week12
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the hello button event handler for the click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text.Length > 0 )
            {
                HelloLabel.Text = "Hello, " + NameTextBox.Text + "!";
            }
            else
            {
                HelloLabel.Text = "Hello World";
            }

            
        }
    }
}
