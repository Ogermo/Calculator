using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        NumberHandler nm = new NumberHandler();

        public double Sin(double one)
        {
            double num;
            num = Math.Sin(Math.PI / 180 * one);
            Console.WriteLine($"sin:({one})={num}");
            Confirm();

            return num;
        }

        public double Cos(double one)
        {
            double num;
            num = Math.Cos(Math.PI / 180 * one);
            Console.WriteLine($"cos:({one})={num}");
            Confirm();

            return num;
        }

        public double Tan(double one)
        {
            double num;
            num = Math.Tan(Math.PI / 180 * one);
            Console.WriteLine($"tan:({one})={num}");
            Confirm();

            return num;
        }

        public double Cot(double one)
        {
            double num;
            num = Math.Tan(Math.PI / 180 * one);
            if (num == 0)
            {
                throw new System.DivideByZeroException();
            }
            num = 1 / num;
            Console.WriteLine($"cot:({one})={num}");
            Confirm();

            return num;
        }

        public double Pow(double one)
        {
            double num;
            Console.Clear();
            Console.WriteLine($"{one}^");
            Console.WriteLine("Write second number");
            double two = GetNumber();
            num = Math.Pow(one, two);
            if (double.IsInfinity(num) || double.IsNaN(num))
            {
                throw new System.OverflowException();
            }
            Console.WriteLine($"{one}^{two}={num}");
            Confirm();

            return num;
        }

        public double Log(double one)
        {
            double num;
            Console.Clear();
            Console.WriteLine($"{one}^");
            Console.WriteLine("Write second number");
            double two = GetNumber();
            num = Math.Log(one, two);
            if (double.IsInfinity(num) || double.IsNaN(num))
            {
                throw new System.OverflowException();
            }
            Console.WriteLine($"Log {two} ({one})={num}");
            Confirm();
            return num;

        }

        public double Fact(double one)
        {
            double num;
            Console.Clear();
            if ((one < 0) || Math.Abs(one % 1) > (Double.Epsilon * 100))
            {
                Console.WriteLine("this operation don't support negative and not whole numbers");
                return one;
            }
            num = 1;
            for (int i = 1; i < one; i++)
            {
                num = num * i;
                if (double.IsInfinity(num) || double.IsNaN(num))
                {
                    throw new System.OverflowException();
                }
            }

            Console.WriteLine($"{one}! ={num}");
            Confirm();

            return num;

        }


        public double Add(double one)
        {
            double num;
            Console.Clear();
            Console.WriteLine($"{one}+");
            Console.WriteLine("Write second number");
            double two = GetNumber();
            num = one + two;
            if (double.IsInfinity(num) || double.IsNaN(num))
            {
                throw new System.OverflowException();
            }
            Console.WriteLine($"{one}+{two}={num}");
            Confirm();

            return num;
        }

        public double Sub(double one)
        {
            double num;
            Console.Clear();
            Console.WriteLine($"{one}-");
            Console.WriteLine("Write second number");
            double two = GetNumber();
            num = one - two;
            if (double.IsInfinity(num) || double.IsNaN(num))
            {
                throw new System.OverflowException();
            }
            Console.WriteLine($"{one}-{two}={num}");
            Confirm();

            return num;
        }

        public double Mult(double one)
        {
            double num;
            Console.Clear();
            Console.WriteLine($"{one}*");
            Console.WriteLine("Write second number");
            double two = GetNumber();
            num = one * two;
            if (double.IsInfinity(num) || double.IsNaN(num))
            {
                throw new System.OverflowException();
            }
            Console.WriteLine($"{one}*{two}={num}");
            Confirm();

            return num;
        }

        public double Div(double one)
        {
            double num;
            Console.Clear();
            Console.WriteLine($"{one}/");
            Console.WriteLine("Write second number");
            double two = GetNumber();
            if (two == 0)
            {
                throw new System.OverflowException();
            }
            num = one / two;
            if (double.IsInfinity(num) || double.IsNaN(num))
            {
                throw new System.OverflowException();
            }
            Console.WriteLine($"{one}/{two}={num}");
            Confirm();
            return num;
        }

        public double FirstNumber()
        {
            double num = GetNumber();
            return num;
        }

        public virtual double GetNumber()
        {
            return nm.GetNumber();
        }

        public virtual void Confirm()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return;
        }

    }
}
