namespace Calculator

// operation overhaul branch

    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        double runningTotal = 0.0;

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelInput.Text = string.Empty;
            this.labelOutput.Text = string.Empty;
            buttonDegrees.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "1";
                this.labelInput.Text = "1";
            }
            else
            {
                input += '1';
                this.labelInput.Text += '1';
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "2";
                this.labelInput.Text = "2";
            }
            else
            {
                input += '2';
                this.labelInput.Text += '2';
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "3";
                this.labelInput.Text = "3";
            }
            else
            {
                input += '3';
                this.labelInput.Text += '3';
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "4";
                this.labelInput.Text = "4";
            }
            else
            {
                input += "4";
                this.labelInput.Text += '4';
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "5";
                this.labelInput.Text = "5";
            }
            else
            {
                input += '5';
                this.labelInput.Text += '5';
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "6";
                this.labelInput.Text = "6";
            }
            else
            {
                input += '6';
                this.labelInput.Text += '6';
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "7";
                this.labelInput.Text = "7";
            }
            else
            {
                input += '7';
                this.labelInput.Text += '7';
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "8";
                this.labelInput.Text = "8";
            }
            else
            {
                input += '8';
                this.labelInput.Text += '8';
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "9";
                this.labelInput.Text = "9";
            }
            else
            {
                input += '9';
                this.labelInput.Text += '9';
            }

        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "0";
                this.labelInput.Text = "0";
            }
            else
            {
                input += "0";
                this.labelInput.Text += '0';
            }

        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);


            if (operand2 == string.Empty)
            {
                this.labelOutput.Text = "SYNTAX ERROR";
            }

            else
            {
                switch (operation)
                {
                    case 'T':
                        if (buttonDegrees.Checked == true)
                        {
                            if (num2 == 90 || num2 == 270)
                            {
                                result = 0;
                                this.labelOutput.Text = "UNDEFINED";
                            }
                            else
                            {
                                result = Math.Round(Math.Tan(Math.PI / 180 * num2), 5);
                            }
                        }

                        else
                        {
                            result = Math.Round(Math.Tan(num2), 5);
                        }

                        if (labelOutput.Text == "= -0")
                        {
                                result = 0;
                                labelOutput.Text = "= " + result.ToString();
                        }

                        else
                        {
                            if (labelOutput.Text == "UNDEFINED")
                            {
                                return;
                            }
                            else
                            {
                                labelOutput.Text = "= " + result.ToString();
                            }
                        }
                        
                        break;
                    case 'C':
                        if (buttonDegrees.Checked == true)
                        {
                            result = Math.Round(Math.Cos(Math.PI / 180 * num2), 5);
                        }

                        else
                        {
                            result = Math.Round(Math.Cos(num2), 5);
                        }
                        if (result == -0)
                        {
                            result = 0;
                            labelOutput.Text = "= " + result.ToString();
                        }

                        else
                        {
                            labelOutput.Text = "= " + result.ToString();
                        }
                        break;
                    case 'S':
                        if (buttonDegrees.Checked == true)
                        {
                            result = Math.Round(Math.Sin(Math.PI / 180 * num2), 5);
                        }

                        else
                        {
                            result = Math.Round(Math.Sin(num2), 5);
                        }
                        if (result == -0)
                        {
                            result = 0;
                            labelOutput.Text = "= " + result.ToString();
                        }

                        else
                        {
                            labelOutput.Text = "= " + result.ToString();
                        }
                        break;
                    case '√':
                        result = Math.Round(Math.Sqrt(num2), 10);
                        labelOutput.Text = "= " + result.ToString();
                        break;
                    case '²':
                        result = Math.Round((num1 * num1), 10);
                        labelOutput.Text = "= " + result.ToString();
                        break;
                    case '+':
                            result = Math.Round((num1 + num2), 10);
                            labelOutput.Text = "= " + result.ToString();
                        break;
                        
                    case '-':
                        result = Math.Round((num1 - num2), 10);
                        labelOutput.Text = "= " + result.ToString();
                        break;
                    case '*':
                        result = Math.Round((num1 * num2), 10);
                        labelOutput.Text = "= " + result.ToString();
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = Math.Round((num1 / num2), 10);
                            labelOutput.Text = "= " + result.ToString();
                        }
                        else
                        {
                            labelOutput.Text = "DIVIDE BY ZERO ERROR";
                        }
                        break;
                }

                
            }

            // clears input and set operands for future calculations
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void checkOperand2()
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            
            if (operand2 != string.Empty)
            {
                switch(operation)
                {
                    case '+':
                        result = Math.Round((num1 + num2), 10); // calculate first and second entered numbers
                        runningTotal = result; // send result to running total
                        result = 0; // clear result
                        operand1 = string.Empty; // set operand 1 to empty
                        operand2 = string.Empty; // set operand 2 to empty
                        input = string.Empty; // set input to empty
                        operand1 = runningTotal.ToString(); // set operand 1 to running total
                        runningTotal = 0; // set running total to 0
                        break; //break

                    case '*':
                        result = Math.Round((num1 * num2), 10);
                        runningTotal = result;
                        result = 0;
                        operand1 = string.Empty;
                        operand2 = string.Empty;
                        input = string.Empty;
                        operand1 = runningTotal.ToString();
                        runningTotal = 0;
                        break;

                    case '/':
                        result = Math.Round((num1 / num2), 10);
                        runningTotal = result;
                        result = 0;
                        operand1 = string.Empty;
                        operand2 = string.Empty;
                        input = string.Empty;
                        operand1 = runningTotal.ToString();
                        runningTotal = 0;
                        break;

                    case '-':
                        result = Math.Round((num1 - num2), 10);
                        runningTotal = result;
                        result = 0;
                        operand1 = string.Empty;
                        operand2 = string.Empty;
                        input = string.Empty;
                        operand1 = runningTotal.ToString();
                        runningTotal = 0;
                        break;
                }


            }

            else
            {
                return;
            }
       }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                operation = '√';
                input = result.ToString();
                this.labelInput.Text = "√(ans)";
            }

            else
            {
                operand2 = input;
                operation = '√';
                input = string.Empty;
                this.labelInput.Text += "√";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                operand1 = result.ToString();
                operation = '/';
                this.labelInput.Text = "Ans/";
                checkOperand2();
            }
            else
            {
                if (operand1 != string.Empty)
                {
                    operand2 = input;
                }

                else
                {
                    operand1 = input;
                    operation = '/';
                    input = string.Empty;
                }
                this.labelInput.Text += '/';
                checkOperand2();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                operand1 = result.ToString();
                operation = '+';
                this.labelInput.Text = "Ans+";
                checkOperand2();
            }
            else
            {
                if (operand1 != string.Empty)
                {
                    operand2= input;
                }

                else
                {
                    operand1 = input;
                    operation = '+';
                    input = string.Empty;
                }
                this.labelInput.Text += '+';
                checkOperand2();
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text  != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                operand1 = result.ToString();
                operation = '*';
                this.labelInput.Text = "Ans×";
                checkOperand2();
            }
            else
            {
                if (operand1 != string.Empty)
                {
                    operand2 = input;
                }

                else
                {
                    operand1 = input;
                    operation = '*';
                    input = string.Empty;
                }
                this.labelInput.Text += '×';
                checkOperand2();
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                operand1 = result.ToString();
                operation = '-';
                this.labelInput.Text = "Ans-";
                checkOperand2();
            }
            else
            {
                if (operand1 != string.Empty)
                {
                    operand2= input;
                }


                else
                {
                    operand1 = input;
                    operation = '-';
                    input = string.Empty;
                }
                this.labelInput.Text += '-';
                checkOperand2();
            }
        }
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                operand1 = result.ToString();
                operation = '²';
                this.labelInput.Text = "Ans²";
            }

            else
            {
                operand1 = input;
                operation = '²';
                this.labelInput.Text += '²';
            }
        }
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                this.labelInput.Text = string.Empty;
            }
            else
            {
                input += ".";
                this.labelInput.Text += '.';
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.labelInput.Text = string.Empty;
            this.labelOutput.Text = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            input = string.Empty;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.input = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
                this.labelOutput.Text = string.Empty;
                this.labelInput.Text = string.Empty;
                input += result;
                this.labelInput.Text += "Ans";
            }
            else
            {
                this.labelOutput.Text = string.Empty;
                input += result;
                this.labelInput.Text += "Ans";
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = result.ToString();
                operation = 'S';
                this.labelInput.Text = "sin(ans)";
            }
            
            else
            {
                operand2 = input;
                operation = 'S';
                input = string.Empty;
                this.labelInput.Text += "sin(";
            }
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = result.ToString();
                operation = 'C';
                this.labelInput.Text = "cos(ans)";
            }

            else
            {
                operand2 = input;
                operation = 'C';
                input = string.Empty;
                this.labelInput.Text += "cos(";
            }
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = result.ToString();
                operation = 'T';
                this.labelInput.Text = "tan(ans)";
            }

            else
            {
                operand2 = input;
                operation = 'T';
                input = string.Empty;
                this.labelInput.Text += "tan(";
            }
        }

        private void buttonDegrees_CheckedChanged(object sender, EventArgs e)
        {
            buttonDegrees.Checked = true;
            buttonRadians.Checked = false;
        }

        private void buttonRadians_CheckedChanged(object sender, EventArgs e)
        {
            buttonDegrees.Checked = false;
            buttonRadians.Checked = true;
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "π";
                this.labelInput.Text = "π";
            }
            else
            {
                input += Math.PI;
                this.labelInput.Text += 'π';
            }
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != string.Empty)
            {
                this.labelOutput.Text = string.Empty;
                input = "-";
                this.labelInput.Text = "-";
            }
            else
            {
                input += '-';
                this.labelInput.Text += '-';
            }
        }
    }
}