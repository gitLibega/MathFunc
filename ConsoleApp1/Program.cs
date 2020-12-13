using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using MathFunc;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{if (!File.Exists("File.csv"))
			{
				File.Create("File.csv");
			}
			StreamWriter sw = new StreamWriter("File.csv");
			Console.Write("Нужная функция(sin,cos,log,ln,sqrt,expression:");
			string func = Console.ReadLine();
			Console.WriteLine("Введите стартовое значение");

			double start = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите шаг функции");

			double step = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите конечное значение");

			double end = Convert.ToDouble(Console.ReadLine());

			
			using var csv = new CsvWriter(sw, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" });
			for (double i = start; i < end; i += step)
			{
				double result = 0;
				if (func == "sin")
				{ result = new MathC().Sin(i); }
				if (func == "cos")
				{ result = new MathC().Cos(i); }
				if (func == "ln")
				{ result = new MathC().Ln(i); }
				if (func == "sqrt")
				{ result = MathC.Sqrt(i); }					
				if (func == "expression")
				{ result = new Expression().Calc(i); }
				csv.WriteRecord(new { X = func+$"({i})", Result = result });

				csv.NextRecord();
			}
			Console.WriteLine($"Результаты вычисления функции {func} сохранены в File.csv");
		}



		}
	}

