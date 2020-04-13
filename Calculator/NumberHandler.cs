using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NumberHandler
    {
        public double GetNumber()
        {
            string str = "";
            double num;
            str = GetString();
            while(!double.TryParse(str, out num))
            {
                str = GetString();
                str = str.Replace(',', '.');
            }
            return num;
        }

        public virtual string GetString()
        {
            return Console.ReadLine();
        }
    }
}
