using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        
        public Form1()
        {
            InitializeComponent();

        }

        private Boolean TextAllowed(String s)
        {
            foreach (Char c in s.ToCharArray())
            {
                if (Char.IsDigit(c)) continue;
                else return false;
            }
            return true;
        }
        private void PreviewTextInputHandler (Object sender, TextCompositionEventArgs e)
        {
            e.Handled = !TextAllowed(e.Text);
            isOperationPerformed = true;
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            outPutTxtBx.Clear();
            resultValue = 0;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((outPutTxtBx.Text == "0") || (isOperationPerformed))
                outPutTxtBx.Clear();

            Button button = (Button)sender;
            outPutTxtBx.Text += button.Text;
            isOperationPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(outPutTxtBx.Text);
            isOperationPerformed = true;
            outPutTxtBx.Text = button.Text + outPutTxtBx.Text;
        }

        private void equals_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case"+":
                    outPutTxtBx.Text = (resultValue + Double.Parse(outPutTxtBx.Text)).ToString();
                    break;
                case "-":
                    outPutTxtBx.Text = (resultValue - Double.Parse(outPutTxtBx.Text)).ToString();
                    break;
                case "*":
                    outPutTxtBx.Text = (resultValue * Double.Parse(outPutTxtBx.Text)).ToString();
                    break;
                case "/":
                    outPutTxtBx.Text = (resultValue / Double.Parse(outPutTxtBx.Text)).ToString();
                    break;
                case "%":
                    outPutTxtBx.Text = (resultValue % Double.Parse(outPutTxtBx.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void backspace_click(object sender, EventArgs e)
        {
            outPutTxtBx.Text = outPutTxtBx.Text.Remove(outPutTxtBx.Text.Length - 1, 1);
        }
    }
}
