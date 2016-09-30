using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
// 3:00pm 30/09/2016 - calculate working, input validating, mock logo in place


namespace Sharp_Mail_Order___Sales_Bonus
{
    public partial class MailOrderSalesBonusForm : Form
    {
        public MailOrderSalesBonusForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// loads the form with focus on the employee name textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailOrderSalesBonusForm_Load(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Focus();
        }

        /// <summary>
        /// determines the sales bonus only if all user input is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (_IsValidTotalMonthlySales() != 0) 
            {
                double TotalBonusAmount = Double.Parse(TotalMonthlySalesTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) * 0.02;
                double PercentageHoursWorked = Convert.ToDouble(TotalHoursWorkedNumericUpDown.Value) / 160;
                double SalesBonus = TotalBonusAmount * PercentageHoursWorked;
                SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            } else {
                SalesBonusTextBox.Text = "$0.00";
            }
        }

        /// <summary>
        /// creates a message box popup to indicate the form is printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (PrintButton.Text.Equals("Print")) {
                MessageBox.Show("The form has been sent to the default printer.", "Printing");
            } else {
                MessageBox.Show("Le formulaire a été envoyé à l'imprimante par défaut.", "Imprimer");
            }
        }

        /// <summary>
        /// clears all the employee information EXCEPT the total monthly sales
        /// and sets the sales bonus back to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            TotalHoursWorkedNumericUpDown.Value = 0;
            SalesBonusTextBox.Text = "$0.00";
        }

        /// <summary>
        /// changes all label and button text to display in english
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// changes all label and button text to display in french
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Validates user input any time the total monthyl sales value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalMonthlySalesTextBox_TextChanged(object sender, EventArgs e)
        {
            _IsValidTotalMonthlySales();
        }

        /// <summary>
        /// determines if the total monthly sales text can be parsed as a double
        /// if it can it returns the value, if not shows an error message
        /// and returns focus to the total monthly sales box
        /// </summary>
        /// <returns></returns>
        private double _IsValidTotalMonthlySales()
        {
            double number;
            if (!Double.TryParse(TotalMonthlySalesTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out number))
            {
                MessageBox.Show("Total Monthly Sales must be a dollar value.", "Invalid Input");
                TotalMonthlySalesTextBox.Focus();
                TotalMonthlySalesTextBox.SelectAll();
            }
            return number;
        }
    }
}
