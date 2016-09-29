using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Sharp Mail Oder - Sales Bonus	
// Created by David McNiven
// Student # 200330143	
// Created on September 30th 2016	
//
// Simple windows form to calculate the total sales bonus per employee based on
// the total monlthy sales for the company and the percentage of which the employee
// in question worked.
//
// CHANGELOG
// 29/09/2016 - initialized project and some ui elements
// 29/09/2016 - 


namespace Sharp_Mail_Order___Sales_Bonus
{
    public partial class MailOrderSalesBonusForm : Form
    {
        public MailOrderSalesBonusForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // determines the sales bonus only if all user input is valid
        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        // creates a message box popup to indicate the form is printing
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form has been sent to the default printer.");
        }

        // clears all the employee information EXCEPT the total monthly sales
        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        // changes all label text to display in english
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        // changes all label text to display in french
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
