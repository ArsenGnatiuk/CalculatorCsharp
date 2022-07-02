using System;
namespace ConsoleWrite
{
	class Program
	{
		static void DeleteM(ref double[] arr, int sizeA, char[] oper, int sizeO, int i)
		{
			char[] newOp = new char[sizeO];
			double[] newArr = new double[sizeA];
			for (int j = 0; j < i; j++)
			{
				newArr[j] = arr[j];
			}
			for (int j = 0; j <= 1; j++)
			{
				double m = arr[i] * arr[i + 1];
				newArr[i] = m;
			}
			for (int j = i + 1; j < sizeA; j++)
			{
				newArr[j] = arr[j + 1];
			}
			arr = newArr;
			sizeA--;
			for (int j = 0; j < sizeA; j++)
			{
				Console.WriteLine(arr[j] + "||||||||||||||||");
			}
			for (int j = 0; j < i; j++)
			{
				newOp[j] = oper[j];
			}
			for (int j = i; j < sizeO; j++)
			{
				newOp[j] = oper[j + 1];
			}
			oper = newOp;
			sizeO--;
			for (int j = 0; j <= sizeO; j++)
			{
				Console.WriteLine(oper[j]);
			}
			Calc(ref arr, oper, sizeO, sizeA);
		}
		static void DeleteMinus(ref double[] arr, int sizeA, char[] oper, int sizeO, int i)
		{
			char[] newOp = new char[sizeO];
			double[] newArr = new double[sizeA];
			for (int j = 0; j < i; j++)
			{
				newArr[j] = arr[j];
			}
			for (int j = i; j <= i; j++)
			{
				double d = arr[i] - arr[i + 1];
				newArr[j] = d;
			}
			for (int j = i + 1; j < sizeA; j++)
			{
				newArr[j] = arr[j + 1];
			}
			arr = newArr;
			sizeA--;
			for (int j = 0; j < sizeA; j++)
			{
				Console.WriteLine(arr[j] + "||||||||||||||||");
			}
			for (int j = 0; j < i; j++)
			{
				newOp[j] = oper[j];
			}
			for (int j = i; j < sizeO; j++)
			{
				newOp[j] = oper[j + 1];
			}
			oper = newOp;
			sizeO--;
			for (int j = 0; j <= sizeO; j++)
			{
				Console.WriteLine(oper[j]);
			}
			Calc(ref arr, oper, sizeO, sizeA);
		}
		static void DeletePlus(ref double[] arr, int sizeA, char[] oper, int sizeO, int i)
		{
			char[] newOp = new char[sizeO];
			double[] newArr = new double[sizeA];
			for (int j = 0; j < i; j++)
			{
				newArr[j] = arr[j];
			}
			for (int j = i; j <= i; j++)
			{
				double d = arr[i] + arr[i + 1];
				newArr[j] = d;
			}
			for (int j = i + 1; j < sizeA; j++)
			{
				newArr[j] = arr[j + 1];
			}
			arr = newArr;
			sizeA--;
			for (int j = 0; j < sizeA; j++)
			{
				Console.WriteLine(arr[j] + "||||||||||||||||");
			}
			for (int j = 0; j < i; j++)
			{
				newOp[j] = oper[j];
			}
			for (int j = i; j < sizeO; j++)
			{
				newOp[j] = oper[j + 1];
			}
			oper = newOp;
			sizeO--;
			for (int j = 0; j <= sizeO; j++)
			{
				Console.WriteLine(oper[j]);
			}
			Calc(ref arr, oper, sizeO, sizeA);
		}
		static void DeleteD(ref double[] arr, int sizeA, char[] oper, int sizeO, int i)
		{
			char[] newOp = new char[sizeO];
			double[] newArr = new double[sizeA];
			for (int j = 0; j < i; j++)
			{
				newArr[j] = arr[j];
			}
			for (int j = i; j <= i; j++)
			{
				double d = arr[i] / arr[i + 1];
				newArr[j] = d;
			}
			for (int j = i + 1; j < sizeA; j++)
			{
				newArr[j] = arr[j + 1];
			}
			arr = newArr;
			sizeA--;
			for (int j = 0; j < sizeA; j++)
			{
				Console.WriteLine(arr[j] + "||||||||||||||||");
			}
			for (int j = 0; j < i; j++)
			{
				newOp[j] = oper[j];
			}
			for (int j = i; j < sizeO; j++)
			{
				newOp[j] = oper[j + 1];
			}
			oper = newOp;
			sizeO--;
			for (int j = 0; j <= sizeO; j++)
			{
				Console.WriteLine(oper[j]);
			}
			Calc(ref arr, oper, sizeO, sizeA);
		}
		static void Calc(ref double[] arr, char[] oper, int sizeO, int sizeA)
		{
			int j = 0;
			for (int i = 0; i < sizeO; i++)
			{
				j++;
				if (oper[i] == '/')
				{

					DeleteD(ref arr, sizeA, oper, sizeO, i);
				}
				if (oper[i] == '*')
				{
					DeleteM(ref arr, sizeA, oper, sizeO, i);
				}
			}
			for (int i = 0; i < sizeO; i++)
			{
				j++;
				if (oper[i] == '-')
				{
					DeleteMinus(ref arr, sizeA, oper, sizeO, i);
				}
				if (oper[i] == '+')
				{
					DeletePlus(ref arr, sizeA, oper, sizeO, i);
				}
			}
			if (j <= 100)
			{
				return;
			}
			Calc(ref arr, oper, sizeO, sizeA);
		}
		static void Main(string[] args)
		{
			string calc;
			int j = 0;
			int sizeA = 0;
			char[] oper = new char[255];
			double[] arr = new double[255];
			Console.WriteLine("Введiть числа щоб зкалькулювати, в порядку 5+9+7-4 = +enter");
			calc = Console.ReadLine();
			for (int i = 0; i < calc.Length; i++)
			{
				if (calc[i] >= '0' && calc[i] <= '9')
				{
					if (i <= calc.Length - 2)
					{
						if (calc[i + 1] >= '0' && calc[i + 1] <= '9')
						{
							if (i <= calc.Length - 3)
								if (calc[i + 2] >= '0' && calc[i + 2] <= '9')
								{
									arr[j] = (calc[i + 2] - '0') + 1.0 * ((calc[i + 1] - '0') + 1.0 * (calc[i] - '0') * 10) * 10;
									j++;
									i += 2;
									continue;
								}
							arr[j] = (calc[i + 1] - '0') + 1.0 * (calc[i] - '0') * 10;
							j++;
							i++;
							continue;
						}
					}
					arr[j] = calc[i] - '0';
					j++;
				}
			}
			sizeA = j;
			int sizeO = 0;
			for (int i = 0; i < calc.Length; i++)
			{
				if (calc[i] == '+' || calc[i] == '-' || calc[i] == '*' || calc[i] == '/')
				{
					oper[sizeO] = calc[i];
					sizeO++;
				}
			}
			Calc(ref arr, oper, sizeO, sizeA);
		}
	}
}