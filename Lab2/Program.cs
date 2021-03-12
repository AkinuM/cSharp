using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class Program
	{
		static void Main(string[] args)
		{
			String str = Console.ReadLine();
			char[] result = new char[str.Length];
			int wordLength = 0, i = 0;
			for (i = str.Length - 1; i >= 0; i--)
			{
				if (str[i]==' ')
				{
					result[str.Length - i - 1] = ' ';
					for(int k = 1; k <= wordLength; k++)
					{
						result[str.Length - i - wordLength - 2 + k] = str[i + k];
					}
					wordLength = 0;
				}
				else
				{
					wordLength++;
				}
			}
			for (int k = 1; k <= wordLength; k++)
			{
				result[str.Length - i - wordLength - 2 + k] = str[i + k];
			}
			for (i = 0; i < str.Length - 1; i++)
			{
				Console.Write(result[i]);
			}
			Console.WriteLine(result[str.Length - 1]);
		}
	}
}