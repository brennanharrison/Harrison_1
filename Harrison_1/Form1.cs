// Programmer: Brennan Harrison
// Project: Harrison_1
// Date: 09/15/2018
// Description: Individual Assignment #1
using System;
using System.Windows.Forms;

namespace Harrison_1
{
    public partial class motorwayMotelFrm : Form
    {
        public motorwayMotelFrm()
        {
            InitializeComponent();
        }

        // Perform calculations and display results in the billing summary group box
        private void totalButton_Click(object sender, EventArgs e)
        {
            // Use the try-catch statement to handle any data entry exceptions
            try
            {
                // Declare local constant
                const decimal TAX_RATE = 0.07m;

                // Declare local variables
                int stayedNights;               // Number of stayed nights
                decimal nightlyRate;            // Nightly rate for checked room
                decimal miniBarCharges;         // Total minibar charges
                decimal telephoneCharges;       // Total telephone charges
                decimal miscellaneousCharges;   // Total miscellaneous charges
                decimal roomCharges;            // Product of stayed nights and nightly rate
                decimal totalAdditionalCharges; // Sum of minibar, telephone, and miscellaneous charges
                decimal subTotal;               // Sum of room charges and additional charges
                decimal taxAmount;              // Tax on subtotal
                decimal totalCharges;           // Sum of subtotal and tax amount

                // Initially store stayed nights and nightly rate variables with 0 to prevent
                // "use of unassigned local variable" errors from occuring at line 69
                // due to the "if" statements at lines 47 and 49
                stayedNights = 0;
                nightlyRate = 0.00m;

                /* Read the values in stayed night and nightly rate textbox controls
                 * and parse them to numeric values.
                 * Store parsed values in the stayed nights and nightly rate variables. */
                if (stayedNightsTextBox.Text != "")                                       // Prevent Parse method from throwing an exception when trying to convert a null value to a numeric data type
                    stayedNights = int.Parse(stayedNightsTextBox.Text);
                if (nightlyRateTextBox.Text != "")                                        // Prevent Parse method from throwing an exception when trying to convert a null value to a numeric data type
                    nightlyRate = decimal.Parse(nightlyRateTextBox.Text);              

                // Initially store additional charge variables with 0 to prevent 
                // "use of unassigned local variable" errors from occuring at line
                // 73 due to the "if" statements at lines 61, 63, and 65
                miniBarCharges = 0.00m;
                telephoneCharges = 0.00m;
                miscellaneousCharges = 0.00m;

                /* Read the values in additional charge text boxes and parse them to numeric values.
                 * Store parsed values in the appropriate additional charge variable. */
                if (miniBarTextBox.Text != "")                                           // Prevent Parse method from throwing an exception when trying to convert a null value to a numeric data type
                    miniBarCharges = decimal.Parse(miniBarTextBox.Text);                
                if (telePhoneTextBox.Text != "")                                         // Prevent Parse method from throwing an exception when trying to convert a null value to a numeric data type
                    telephoneCharges = decimal.Parse(telePhoneTextBox.Text);
                if (miscellaneousTextBox.Text != "")                                     // Prevent Parse method from throwing an exception when trying to convert a null value to a numeric data type
                    miscellaneousCharges = decimal.Parse(miscellaneousTextBox.Text);

                // Calculate and display room charges
                roomCharges = stayedNights * nightlyRate;
                roomChargesOutputLabel.Text = roomCharges.ToString("c");

                // Calculate and display additional charges
                totalAdditionalCharges = miniBarCharges + telephoneCharges + miscellaneousCharges;
                totalAdditionalChargesOutputLabel.Text = totalAdditionalCharges.ToString("c");

                // Calculate and display subtotal
                subTotal = roomCharges + totalAdditionalCharges;
                subTotalOutputLabel.Text = subTotal.ToString("c");

                // Calculate and display the tax amount on the subtotal
                taxAmount = subTotal * TAX_RATE;
                taxAmountOutputLabel.Text = taxAmount.ToString("c");

                // Calculate and display the customer's total charges
                totalCharges = subTotal + taxAmount;
                totalChargesOutputLabel.Text = totalCharges.ToString("c");

                // Set the focus to the clear button
                clearButton.Focus();
            }
            catch 
            {
                // Display an error message asking for the correct data
                MessageBox.Show("Please enter the correct data for the appropriate information and charges!");
            }
        }
        
        // Clear all input and output controls
        private void clearButton_Click(object sender, EventArgs e)
        {
            checkOutMaskedTextBox.Text = "";             // Empty the checkout date masked text box
            firstNameTextBox.Text = "";                  // Empty the first name text box
            lastNameTextBox.Text = "";                   // Empty the last name text box
            roomNumberMaskedTextBox.Text = "";           // Empty the room number masked text box
            stayedNightsTextBox.Text = "";               // Empty the stayed nights text box
            nightlyRateTextBox.Text = "";                // Empty the nightly rate text box
            miniBarTextBox.Text = "";                    // Empty the minibar charges text box
            telePhoneTextBox.Text = "";                  // Empty the telephone charges text box
            miscellaneousTextBox.Text = "";              // Empty the miscellaneous charges text box
            roomChargesOutputLabel.Text = "";            // Empty the room charges output label
            totalAdditionalChargesOutputLabel.Text = ""; // Empty the additional charges output label
            subTotalOutputLabel.Text = "";               // Empty the subtotal output label
            taxAmountOutputLabel.Text = "";              // Empty the tax amount output label
            totalChargesOutputLabel.Text = "";           // Empty the total charges output label

            // Set the focus to the checkout masked text box control
            checkOutMaskedTextBox.Focus();
        }

        // Display a message box to provide help
        private void helpButton_Click(object sender, EventArgs e)
        {
            // Display a message box explaining how to generate the bill summary,
            // clear the input and output controls, what the help button will explain,
            // and how to close the application.
            MessageBox.Show("Enter the guest's checkout date and information. "
                              + " Next, enter the applicable room information and any additional charges. "
                              + " Finally, click the Total button to display all checkout charges. "
                              + " Click the Clear button to empty all input and output information. "
                              + " Clicking on the Help button will explain how to use the check-out application. "
                              + " The Exit button will close the check-out application.");
        }

        // Close the form (ending the program)
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
