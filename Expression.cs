using System;
using System.Collections.Generic;
using System.Text;


namespace MathFunc
{
	public class Expression
	{

        MathC CustomMath = new MathC();
        public double Calc(double x)
        {
            if (x <= 0)
            {
                return (CustomMath.Pow((((CustomMath.Pow(CustomMath.Sin(x), 3) + (CustomMath.Csc(x) + CustomMath.Sin(x))) / CustomMath.Sin(x)) / CustomMath.Sin(x)), 2));

            }
            else
            {
                return CustomMath.Pow(((CustomMath.Log(x, 5) * CustomMath.Pow(CustomMath.Ln(x), 2)) + (CustomMath.Log(x, 2) * CustomMath.Ln(x))), 3) / (CustomMath.Pow(CustomMath.Ln(x), 2));
            }
        }
     

    }
}
