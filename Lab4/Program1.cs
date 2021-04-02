using System;
using System.Runtime.InteropServices;


namespace inputAndOutput
{
	class Program
	{
		[DllImport("inputAndOutput.dll", CallingConvention = CallingConvention.StdCall)]
		private static extern double add(double numb1, double numb2);

		[DllImport("inputAndOutput.dll", CallingConvention = CallingConvention.StdCall)]
		private static extern double substract(double numb1, double numb2);

		static void Main(string[] args)
		{
			double qwe;
			qwe = add(4.2, 5.8);
			Console.WriteLine(qwe);
			qwe = substract(4.2, 5.8);
			Console.WriteLine(qwe);
		}
	}
}
