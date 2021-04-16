using System;

namespace dotaPlayer
{
	class Program
	{
		static void Main(string[] args)
		{
			pos5DotaPlayer fsdf = new pos5DotaPlayer();
			Console.WriteLine($"{fsdf.Role}");
			Console.WriteLine($"{fsdf.MMR}");
			fsdf.playGame("Lina", "Middle");
			Console.WriteLine($"{fsdf.MMR}");
			fsdf.playGame("Lina", "Middle");
			Console.WriteLine($"{fsdf.MMR}");
			pos1DotaPlayer qwe = new pos1DotaPlayer();
			qwe.playGame("Lina", "Middle");
			pos3DotaPlayer ert = new pos3DotaPlayer();
			ert.playGame("Lina", "Middle");
		}
	}
}
