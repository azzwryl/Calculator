using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private String operators;
        private double entryBeforeOperator = 0;
        private String entryBeforeOperatorToString;
        private double entryAfterOperator = 0;
        private String entryAfterOperatorToString;
        private double result;
        private bool equalButtonPressed = false;

        public CalculatorForm()
        {
            InitializeComponent();

            displayValue.Text = entryBeforeOperator.ToString();
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            //clears most recent entry.
            if (operators != null)
            {
                operators = null;
            } else
            {
                displayValue.Text = "0";
                displayValue.Refresh();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text != "0")
            {
                String str = displayValue.Text;

                str = str.Remove(str.Length - 1);
                displayValue.Text = str;
                displayValue.Refresh();
            }

            if (displayValue.TextLength == 0)
            {
                displayValue.Text = "0";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clears all input.

            if (displayValue.Text != "0")
            {
                displayValue.Clear();
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            operators = "/";
            entryBeforeOperatorToString = displayValue.Text;

            if (equalButtonPressed)
            {
                entryBeforeOperatorToString = displayValue.Text;
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            operators = "x";
            entryBeforeOperatorToString = displayValue.Text;

            if (equalButtonPressed)
            {
                entryBeforeOperatorToString = displayValue.Text;
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            operators = "-";
            entryBeforeOperatorToString = displayValue.Text;

            if (equalButtonPressed)
            {
                entryBeforeOperatorToString = displayValue.Text;
            }
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            operators = "+";
            entryBeforeOperatorToString = displayValue.Text;

            if (equalButtonPressed)
            {
                entryBeforeOperatorToString = displayValue.Text;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            entryAfterOperatorToString = displayValue.Text;
            entryBeforeOperator = Double.Parse(entryBeforeOperatorToString);
            entryAfterOperator = Double.Parse(entryAfterOperatorToString);

            switch(operators)
            {
                case "/":
                    result = entryBeforeOperator / entryAfterOperator;
                    break;
                case "x":
                    result = entryBeforeOperator * entryAfterOperator;
                    break;
                 case "-":
                    result = entryBeforeOperator - entryAfterOperator;
                    break;
                case "+":
                    result = entryBeforeOperator + entryAfterOperator;
                    break;
            }

            displayValue.Text = result.ToString();
            displayValue.Refresh();
            equalButtonPressed = true;
            operators = null;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text != "0")
            {
                String str = displayValue.Text;

                str = str.Insert(displayValue.TextLength, "0");
                displayValue.Text = str;
                displayValue.Refresh();
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "7");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "8");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "9");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "4");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "5");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "6");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "1");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "2");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (displayValue.Text == "0" || operators != null)
            {
                displayValue.Text = null;
            }

            if (equalButtonPressed)
            {
                displayValue.Text = null;
            }

            String str = displayValue.Text;

            str = str.Insert(displayValue.TextLength, "3");
            displayValue.Text = str;
            displayValue.Refresh();
            equalButtonPressed = false;
        }
    }
}
