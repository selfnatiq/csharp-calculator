using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// Basic Calculator App
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text ------------- Just git test
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>

        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from user input
            this.UserInputText.Clear();
            
            // Focus the user input text
            FocusInput();
        }        

        private void DelButton_Click(object sender, EventArgs e)
        {
            // Delete the value in front of the cursor in user input text
            DeleteTextValue();

            // Focus the user input text
            FocusInput();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            // Delete the value in front of the cursor in user input text
            DeleteTextValue();

            // Focus the user input text
            FocusInput();
        }

        #endregion

        #region Number Methods

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            // Focus the user input text
            FocusInput();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            // Focus the user input text
            FocusInput();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            // Focus the user input text
            FocusInput();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            // Focus the user input text
            FocusInput();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            // Focus the user input text
            FocusInput();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            // Focus the user input text
            FocusInput();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            // Focus the user input text
            FocusInput();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            // Focus the user input text
            FocusInput();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            // Focus the user input text
            FocusInput();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            // Focus the user input text
            FocusInput();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            // Focus the user input text
            FocusInput();
        }

        #endregion

        #region Operator Methods

        private void DividButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            // Focus the user input text
            FocusInput();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("x");

            // Focus the user input text
            FocusInput();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            // Focus the user input text
            FocusInput();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            // Focus the user input text
            FocusInput();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            // Focus the user input text
            FocusInput();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInput()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given value into user input text
        /// </summary>
        /// <param name="value">Value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If we don't have a value to delete > return
            if (this.UserInputText.SelectionStart == 0 || (this.UserInputText.SelectionStart > this.UserInputText.TextLength))
                return;

            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection                   
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart - 1, 1);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            var userInput = this.UserInputText.Text;

            var result = ParseOperation();

            
        }

        /// <summary>
        /// Parses the user equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                var input = this.UserInputText.Text;

                // Removes all spaces in text box
                input = input.Replace(" ", "");

                var operation = new Operation();
                var leftside = true;

                return string.Empty;

            }
            catch (Exception e)
            {
                return $"Invalid equation. {e.Message}";
            }
        }

        #endregion
    }
}
