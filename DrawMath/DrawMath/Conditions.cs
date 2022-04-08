using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMath
{
    public abstract class Conditions
    {
        public static string[] tryg_functions = { "sin", "cos", "tg", "ctg" };
        public bool IfLinearFunction(string input)
        {
            if (input.Contains("x") && input.Contains("x^") == false)
            {
                foreach (string func in tryg_functions)
                {
                    if (input.Contains(func))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }

        public bool IfSquareFunction(string input)
        {
            if (input.Contains("x^"))
            {
                foreach (string func in tryg_functions)
                {
                    if (input.Contains(func))
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
        public bool IfTrygoFunction(string input)
        {
            foreach (string func in tryg_functions)
            {
                if (input.Contains(func))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
