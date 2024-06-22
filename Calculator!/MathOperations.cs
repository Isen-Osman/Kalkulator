using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator_
    {
        public class MathOperations
        {
            public double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Subtract(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Divide(double num1, double num2)
            {
            if (num2 == 0)
            {
                
                MessageBox.Show("Не може да се пресметува со 0", "Известување");
                return 0; 
            }

           
            return num1 / num2;
        }
    

            public double Percent(double num)
            {
                return num / 100;
            }

            public double Square(double num)
            {
                return num * num;
            }

            public double Cube(double num)
            {
                return num * num * num;
            }

            public double Log(double num)
            {
                if (num <= 0 && num!=null)
                    throw new ArgumentOutOfRangeException("nevalidno");
                return Math.Log10(num);
            }

            public double Sqrt(double num)
            {
                return Math.Sqrt(num);
            }

            public double Sin(double num)
            {
                return Math.Sin(num);
            }

            public double Sinh(double num)
            {
                return Math.Sinh(num);
            }

            public double Cos(double num)
            {
                return Math.Cos(num);
            }

            public double Cosh(double num)
            {
                return Math.Cosh(num);
            }

            public double Tan(double num)
            {
                return Math.Tan(num);
            }

            public double Tanh(double num)
            {
                return Math.Tanh(num);
            }

            public double Reciprocal(double num)
            {
                if (num == 0)
            {
                MessageBox.Show("Неможе да се конвертира бројот 0.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

            return 1.0 / num;
            }

            public double Ln(double num)
            {
                if (num <= 0)
                    throw new ArgumentOutOfRangeException();
                return Math.Log(num);
            }

            public int ToInt(double num)
            {
                return Convert.ToInt32(num);
            }

            public string ToBinary(int num)
            {
                return Convert.ToString(num, 2);
            }

            public string ToHex(int num)
            {
                return Convert.ToString(num, 16);
            }

            public string ToOctal(int num)
            {
                return Convert.ToString(num, 8);
            }
        public int Decimal(double number)
        {
            int decimalPart = (int)number; 
            return decimalPart;
        }


        public double Mod(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("Неможе да се конвертира бројот 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return num1 % num2;
        }

       
        public double Exp(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        public int FromHex(string hex)
        {
            // Користи вграден метод за парсирање на хексадецимални броеви во децимални
            return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }
        public int FromBinary(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        // Метод за конвертирање осмичен број во децимален број
        public int FromOctal(string octal)
        {
            return Convert.ToInt32(octal, 8);
        }
    }
    }
