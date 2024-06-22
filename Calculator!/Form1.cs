using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {

        Double result = 0;
        string operation = string.Empty;
        private bool enterValue;
        string firstNum,secondNum;
        private bool isExpanded = false;
        private const int originalWidth = 312;
        private const int expandedWidth = 620;
        MathOperations mathOperations;
        private List<Button> numberButtons;
   
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            mathOperations = new MathOperations();
            numberButtons = new List<Button> { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            UpdateLightTheme();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 313;
            this.txtDisplayNumber.Width = 313;

        }

        private void UpdateColorScheme(Color backColor, Color textColor, Color buttonColor)
        {
            this.BackColor = backColor;
            txtDisplayBack.BackColor = backColor;
            txtDisplayNumber.BackColor = backColor;
            panelHistory.BackColor = backColor;
            boxTextHistory.BackColor = backColor;

            foreach (var button in numberButtons)
            {
                button.ForeColor = textColor;
            }

            btnProcent.ForeColor = textColor;
            btnDot.ForeColor = textColor;
            btnBin.ForeColor = textColor;
            btnCosh.ForeColor = textColor;
            btn1x.ForeColor = textColor;
            btnSinH.ForeColor = textColor;
            btnSIn.ForeColor = textColor;
            btnDecimal.ForeColor = textColor;
            btnX2.ForeColor = textColor;
            btnX3.ForeColor = textColor;
            btnLog.ForeColor = textColor;
            btnCos.ForeColor = textColor;
            btnCosh.ForeColor = textColor;
            btnBin.ForeColor = textColor;
            btnBin.ForeColor = textColor;
            btnTan.ForeColor = textColor;
            btnTanh.ForeColor = textColor;
            btnHex.ForeColor = textColor;
            btnInX.ForeColor = textColor;
            btnOct.ForeColor = textColor;
            btnPi.ForeColor = textColor;
            btnSqrt.ForeColor = textColor;
            btnEqual.BackColor = buttonColor;
            btnEqual.ForeColor = backColor;
            btnDeleteAll.BackColor = backColor;
            boxTextHistory.ForeColor = textColor;
            txtDisplayBack.ForeColor = textColor;
            txtDisplayNumber.ForeColor = textColor;
        }
        private void UpdateDarkTheme()
        {
            UpdateColorScheme(Color.FromArgb(111, 78, 55), Color.FromArgb(254, 216, 177), Color.FromArgb(254, 216, 177));
        }

        private void UpdateLightTheme()
        {
            UpdateColorScheme(Color.FromArgb(254, 216, 177), Color.FromArgb(111, 78, 55), Color.FromArgb(111, 78, 55));
        }

        private void rJButtonDarkWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (btnWhiteOrDark.Checked)
            {
                UpdateDarkTheme();
            }
            else
            {
                UpdateLightTheme();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сакате да ја исклучите апликацијата?", "Калкулатор",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtDisplayNumber.Text == "0")
                txtDisplayNumber.Text = "";
            {
                if(num.Text == ".")
                {
                    if (!txtDisplayNumber.Text.Contains("."))
                    {
                        txtDisplayNumber.Text = txtDisplayNumber.Text + num.Text;
                    }
                }
                else
                {
                    txtDisplayNumber.Text = txtDisplayNumber.Text + num.Text;
                }
            }
        }
        private void btnMathOperation_Click(object sender, EventArgs e)
        {
            try
            {
                // Користење на ParseInput наместо Double.Parse
                if (result != 0)
                {
                    btnEqual.PerformClick();
                }
                else
                {
                    result = ParseInput(txtDisplayNumber.Text); // Конверзија на влезот во број
                }

                Button but = (Button)sender;
                operation = but.Text;
                enterValue = true;

                if (txtDisplayNumber.Text != "0")
                {
                    txtDisplayBack.Text = firstNum = $"{result}{operation}";
                    txtDisplayNumber.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внесовте невалиден бројен формат. Ве молиме обидете се повторно.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDisplayNumber.Text = "0";
                txtDisplayBack.Text = string.Empty;
                result = 0;
                operation = String.Empty;
            }
        }
        private void btnEdn_Click(object sender, EventArgs e)
        {

            secondNum = txtDisplayNumber.Text;

            txtDisplayBack.Text = $"{txtDisplayBack.Text}{txtDisplayNumber.Text}";

            if (txtDisplayNumber.Text != string.Empty)
            {

                if (txtDisplayNumber.Text == "0") txtDisplayBack.Text = string.Empty;

                double secondNumber;

                if (Double.TryParse(txtDisplayNumber.Text, out secondNumber))
                {
                    double resultValue = 0;

                    try
                    {

                        switch (operation)
                        {
                            case "+":
                                resultValue = mathOperations.Add(result, secondNumber);
                                break;
                            case "-":
                                resultValue = mathOperations.Subtract(result, secondNumber);
                                break;
                            case "×":
                                resultValue = mathOperations.Multiply(result, secondNumber);
                                break;
                            case "÷":
                                resultValue = mathOperations.Divide(result, secondNumber);
                                break;


                            default:
                                txtDisplayBack.Text = $"{txtDisplayNumber.Text}=";
                                return;
                        }
                        txtDisplayNumber.Text = resultValue.ToString();
                        boxTextHistory.AppendText($"{firstNum}{secondNum} = {txtDisplayNumber.Text}\n");
                        result = resultValue;
                        operation = String.Empty;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Внесовте невалиден бројен формат. Ве молиме обидете се повторно.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }
        

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(panel1.Height == 0  )
            {
                panel1.Height = 360;
              
            }
            else
            {
                panel1.Height = 0;
                
            }
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            boxTextHistory.Clear();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplayNumber.Text = "0";
            txtDisplayBack.Text = string.Empty;
            result = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplayNumber.Text.Length > 0) txtDisplayNumber.Text = txtDisplayNumber.Text.Remove(txtDisplayNumber.Text.Length-1,1);

            if (txtDisplayNumber.Text == string.Empty) txtDisplayNumber.Text = "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                this.Width = originalWidth;
                this.txtDisplayNumber.Width = originalWidth;
                this.txtDisplayBack.Width = originalWidth;
                this.boxTextHistory.Width = originalWidth;              
            }
            else
            {
                this.Width = expandedWidth;
                this.txtDisplayNumber.Width = expandedWidth;
                this.txtDisplayBack.Width = expandedWidth;
            }
            isExpanded = !isExpanded;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                a = Convert.ToDouble(txtDisplayNumber.Text) / Convert.ToDouble(100);

                txtDisplayNumber.Text = Convert.ToString(a);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = mathOperations.Square(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = Convert.ToString(x);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во x2 број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            try
            {
                double x = mathOperations.Cube(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = Convert.ToString(x);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во x3 број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                double log = mathOperations.Log(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = log.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за логаритам.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double sqrt = mathOperations.Sqrt(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = sqrt.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за квадратен корен.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSIn_Click(object sender, EventArgs e)
        {
            try
            {
                double sin = mathOperations.Sin(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = sin.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за синус.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSinH_Click(object sender, EventArgs e)
        {
            try
            {
                double sinh = mathOperations.Sinh(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = sinh.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за хиперболичен синус.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCosh_Click(object sender, EventArgs e)
        {
            try
            {
                double cosh = mathOperations.Cosh(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = cosh.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за хиперболичен косинус.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double cos = mathOperations.Cos(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = cos.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за косинус.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTanh_Click(object sender, EventArgs e)
        {
            try
            {
                double tanh = mathOperations.Tanh(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = tanh.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за хиперболичен тангенс.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                double tan = mathOperations.Tan(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = tan.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Не валиден број формат. Внесете валиден број за тангенс.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            try { 
            double num = Convert.ToDouble(txtDisplayNumber.Text);
            double reciprocal = mathOperations.Reciprocal(num);
            txtDisplayNumber.Text = reciprocal.ToString();
            }      
             catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во x број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnInX_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtDisplayNumber.Text);
                x = Math.Log(x);
                txtDisplayNumber.Text = Convert.ToString(x);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира вo број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private double ParseInput(string input)
        {
        double number;

        try
        {
        // Проверува дали влезниот текст е хексадецимален број
        if (input.StartsWith("0x"))
        {
            number = mathOperations.FromHex(input.Substring(2)); // Избриши "0x" пред парсирање
        }
        else if (input.StartsWith("0b")) // Ако е бинарен број
        {
            number = mathOperations.FromBinary(input.Substring(2)); // Избриши "0b" пред парсирање
        }
        else if (input.StartsWith("0o")) // Ако е осмичен број
        {
            number = mathOperations.FromOctal(input.Substring(2)); // Избриши "0o" пред парсирање
        }
        else // Ако е децимален број
        {
            number = double.Parse(input); // Парсирај директно
        }
    }
        catch (Exception ex)
        {
            MessageBox.Show("Внесовте невалиден бројен формат. Ве молиме обидете се повторно.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            number = 0;
        }
            return number;
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtDisplayNumber.Text, out double number))
                {
                    int decimalPart = mathOperations.Decimal(number);
                    txtDisplayNumber.Text = decimalPart.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во децимален број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnBin_Click(object sender, EventArgs e)
        {
            try
            {
                int n = mathOperations.ToInt(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = mathOperations.ToBinary(n);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во бинарен број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            try
            {
                
                int n = mathOperations.ToInt(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = mathOperations.ToHex(n);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неможе да се конвертира бројот", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            try
            {
                int n = mathOperations.ToInt(Convert.ToDouble(txtDisplayNumber.Text));
                txtDisplayNumber.Text = mathOperations.ToOctal(n);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во октален број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void richTextBox1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Width = ClientSize.Width;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            try
            {
                double pi = Convert.ToDouble(txtDisplayNumber.Text) * Math.PI;

                txtDisplayNumber.Text = pi.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не може да се конвертира во децимален број.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
