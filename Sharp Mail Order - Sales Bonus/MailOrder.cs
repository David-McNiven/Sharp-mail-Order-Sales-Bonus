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
// 5:00pm 29/09/2016 - initialized project and some form elements
// 6:00pm 29/09/2016 - added all form elements and started on basic funtionality
//                     including tab order, alt+keyboard shortcuts and print message box
// 7:00pm 29/09/2016 - languange switch working, next button working


namespace Sharp_Mail_Order___Sales_Bonus
{
    public partial class MailOrderSalesBonusForm : Form
    {
        public MailOrderSalesBonusForm()
        {
            InitializeComponent();
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
            MessageBox.Show("The form has been sent to the default printer.", "Printing");
        }

        // clears all the employee information EXCEPT the total monthly sales
        // and sets the sales bonus back to default
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            TotalHoursWorkedTextBox.Text = "";
            SalesBonusTextBox.Text = "0.00";
        }

        // changes all label and button text to display in english
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Employee Name";
            EmployeeIDLabel.Text = "Employee ID";
            TotalHoursWorkedLabel.Text = "Total Hours Worked";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            SalesBonusLabel.Text = "Sales Bonus";
            LanguagesGroupBox.Text = "Language";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            NextButton.Text = "Next";
        }

        // changes all label and button text to display in french
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nom de l'Employé";
            EmployeeIDLabel.Text = "Employé ID";
            TotalHoursWorkedLabel.Text = "Total des Heures Travaillées";
            TotalMonthlySalesLabel.Text = "Total des Ventes Mensuelles";
            SalesBonusLabel.Text = "Bonus de Vente";
            LanguagesGroupBox.Text = "Langue";
            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            NextButton.Text = "Suivant";
        }
    }
}
