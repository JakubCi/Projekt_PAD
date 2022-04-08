using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawMath
{
    public class Function : Conditions
    {
        private string input;

        public void SetInput(string value)
        {
            input = value.ToLower();
        }
        public string GetInput()
        {
            return input;
        }

        public Dictionary<double, double> Evaluate(float accuracy)
        {
            if (IfLinearFunction(input))
            {
                Console.WriteLine();
                return LinearFunction(input, accuracy);
            }
            else if (IfSquareFunction(input))
            {
                return SquareFunction(input, accuracy);
            }
            else if (IfTrygoFunction(input))
            {
                return TrygoFunction(input, accuracy);
            }
            else return LinearFunction(input, accuracy);
        }

        private double CalcY(string input, double x)
        {
            return Convert.ToDouble(new Expression("(" + input.Substring(input.IndexOf('=') + 1).Replace("|", string.Empty).Replace("x", "(" + Convert.ToString(x) + ")").Replace(",", ".") + ")*(-1)").calculate());
        }
        private double CalcYAbs(string input, double x)
        {
            return AbsoluteValue(Convert.ToDouble(new Expression("(" + input.Substring(input.IndexOf('=') + 1).Replace("|", string.Empty).Replace("x", "(" + Convert.ToString(x) + ")").Replace(",", ".") + ")*(-1)").calculate()));
        }
        private Dictionary<double, double> LinearFunction(string input, float accuracy)
        {
            Dictionary<double, double> LinearFunctionPoints = new Dictionary<double, double>();
            for (double i = -10; i <= 10; i += accuracy)
            {
                Console.Write(i+" ");
                if (CalcY(input, Math.Round(i, 2)) <= 15 && CalcY(input, Math.Round(i, 2)) >= -15)
                {
                    if (input.Contains("|"))
                    {
                        if (i < 0)
                        {
                            LinearFunctionPoints.Add(Math.Round(i, 2), CalcYAbs(input, Math.Round(i, 2))*-1);
                        }
                        else
                        {
                            LinearFunctionPoints.Add(Math.Round(i, 2), CalcYAbs(input, Math.Round(i, 2))*-1);
                        }
                    }
                    else LinearFunctionPoints.Add(Math.Round(i, 2), CalcY(input, Math.Round(i, 2)));
                }
            }
            return LinearFunctionPoints;
        }
        private Dictionary<double, double> SquareFunction(string input, float accuracy)
        {
            Dictionary<double, double> SquareFunctionPoints = new Dictionary<double, double>();
            for (double i = -10; i <= 10; i += accuracy)
            {
                if (CalcY(input, Math.Round(i, 2)) <= 15 && CalcY(input, Math.Round(i, 2)) >= -15)
                {

                    if (input.Contains("|"))
                    {
                        if (i < 0)
                        {
                            SquareFunctionPoints.Add(Math.Round(i, 2), CalcYAbs(input, Math.Round(i, 2)) * -1);
                        }
                        else
                        {
                            SquareFunctionPoints.Add(Math.Round(i, 2), CalcYAbs(input, Math.Round(i, 2)) * -1);
                        }
                    }
                    else SquareFunctionPoints.Add(Math.Round(i, 2), CalcY(input, Math.Round(i, 2)));
                }
            }
            return SquareFunctionPoints;
        }
        private Dictionary<double, double> TrygoFunction(string input, float accuracy)
        {
            Dictionary<double, double> TrygoFunctionPoints = new Dictionary<double, double>();
            {
                for (double i = -10; i <= 10; i += accuracy)
                    if (CalcY(input, Math.Round(i, 2)) <= 15 && CalcY(input, Math.Round(i, 2)) >= -15)
                    {
                        TrygoFunctionPoints.Add(Math.Round(i, 2), CalcY(input, Math.Round(i, 2)));
                    }
            }
            return TrygoFunctionPoints;
        }
        private double AbsoluteValue(double value)
        {
            if (value > 0)
            {
                return value;
            }
            return value * -1;
        }
    }
}
