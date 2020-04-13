using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Commands =
            {
                "+",
                "-",
                "\\",
                "*",
                "^",
                "!",
                "log",
                "ln",
                "sin",
                "cos",
                "tan",
                "cot"
            };

            Operations op = new Operations();
            double num = 0;
            string operant = "";

            Console.WriteLine("Write first number");
            num = op.FirstNumber();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{num}");
                Console.Write("Choose operant:");
                foreach (string c in Commands)
                {
                    Console.Write($" {c},");
                }
                Console.WriteLine("or \"exit\" to exit");
                bool correct = false;
                while (!correct)
                {
                    operant = Console.ReadLine();
                    correct = true;
                    switch (operant)
                    {
                        case "+":
                            num = op.Add(num);
                            break;
                        case "-":
                            num = op.Sub(num);
                            break;
                        case "*":
                            num = op.Mult(num);
                            break;
                        case "/":
                            num = op.Div(num);
                            break;
                        case "!":
                            num = op.Fact(num);
                            break;
                        case "^":
                            num = op.Pow(num);
                            break;
                        case "log":
                            num = op.Log(num);
                            break;
                        case "ln":
                            num = op.Ln(num);
                            break;
                        case "sin":
                            num = op.Sin(num);
                            break;
                        case "cos":
                            num = op.Cos(num);
                            break;
                        case "tan":
                            num = op.Tan(num);
                            break;
                        case "cot":
                            num = op.Cot(num);
                            break;
                        case "exit":
                            return;
                        default:
                            correct = false;
                            break;
                    }
                }
            }
        }
    }
}
