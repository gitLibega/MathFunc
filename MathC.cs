using System;

namespace MathFunc
{
	public class MathC
	{
		public  double Sin(double x, int nTerms = 30)

		{

			if (nTerms < 2)

				return x;

			if (nTerms == 2)

				return x - (x * x * x) / 6D;

			var multiplyResult = x * x * x;

			var factorialStart = 5;

			double factorialResult = 6;

			var result = x - multiplyResult / factorialResult;

			var sign = 1;

			for (int i = 3; i <= nTerms; i++)

			{

				multiplyResult *= x * x;

				factorialResult *= factorialStart * (factorialStart - 1);

				factorialStart += 2;

				result += sign * (multiplyResult / factorialResult);

				sign *= -1;

			}

			return result;

		}

		public  double Cos(double x, int nTerms = 30)

		{

			if (nTerms < 2)

				return 1;

			if (nTerms == 2)

				return 1 - (x * x) / 2D;

			var multiplyResult = x * x;

			var factorialStart = 4;

			double factorialResult = 2;

			var result = 1 - multiplyResult / factorialResult;

			var sign = 1;

			for (int i = 3; i <= nTerms; i++)

			{

				multiplyResult *= x * x;

				factorialResult *= factorialStart * (factorialStart - 1);

				factorialStart += 2;

				result += sign * (multiplyResult / factorialResult);

				sign *= -1;

			}

			return result;

		}

		public  double Ln(double power)

		{

			if (power == 1) return 0;

			const double e = 2.71828182845905;

			var p = power;

			var n = 0.0;

			double a;

			while (p >= e)

			{

				p /= e;

				n++;

			}

			n += (p / e);

			p = power;

			do

			{

				a = n;

				var l = (p / (Exp(n - 1.0)));

				var r = ((n - 1.0) * e);

				n = ((l + r) / e);

			} while (Abs(n - a) > 0.001);

			return n;

		}

		public double Log(double x, double newBase)

		{

			return Ln(x) / Ln(newBase);

		}

		public  double Exp(double n)

		{

			double x = n;

			double p = 1.0 + x;

			double fact = x;

			double i = 1.0;

			double l;

			do

			{

				i++;

				fact *= (x / i);

				l = p;

				p += fact;

			} while (Abs(l - p) > 0.001);

			return p;

		}

		public  double tan(double x)

		{

			return Sin(x) / Cos(x);

		}

		public  double cotan(double x)

		{

			return Cos(x) / Sin(x);

		}

		public  double Cos2(double x)

		{

			return 1 - Sin(x) * Sin(x);

		}

		public  double Sec(double x)

		{

			return 1 / Cos(x);

		}

		public  double Csc(double x)

		{

			return 1 / Sin(x);

		}

		public double Pow(double x, int radix)

		{

			if (radix == 0) return 1;

			var res = x;

			var absRadix = Abs(radix);

			for (int i = 1; i < absRadix; i++)

			{

				res *= x;

			}

			return radix > 0 ? res : 1 / res;

		}

		public static double Abs(double x)

		{

			return x >= 0 ? x : -x;

		}

		public static double Sqrt(double x)

		{

			double s = 1.0;

			double l;

			do

			{

				l = x / s;

				s = (l + s) / 2;

			} while (Abs(l - s) > 0.000001);

			return s;

		}

	}

}
