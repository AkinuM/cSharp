using System;

namespace dotaPlayer
{
	class pos5DotaPlayer : dotaPlayer
	{
		public override void playGame(string changeHero, string changeLine)
		{
			endGame += endGameMessage;
			hero = changeHero;
			line = changeLine;
			while (true)
			{
				Console.WriteLine("Do you want to buy item?");
				string change1 = Console.ReadLine();
				if (change1 == "yes")
				{
					buyItem();
				}
				else
				{
					break;
				}
			}
			Console.WriteLine("Do you want to give tango pos1?");
			string change2 = Console.ReadLine();
			if (change2 == "yes")
			{
				Console.WriteLine("How many?");
				int count = Convert.ToInt32(Console.ReadLine());
				giveTango(count);
			}
			standAfk();
			if (gameResult())
			{
				Console.WriteLine("You win! Congratulate!");
				mmr += 30;
			}
			else
			{
				Console.WriteLine("You lost. Don't worry!");
				mmr -= 30;
			}
		}

		public pos5DotaPlayer()
		{
			Console.Write("Enter your MMR: ");
			mmr = Convert.ToInt32(Console.ReadLine());
			role = 5;
		}

		private void giveTango(int count)
		{
			Console.WriteLine($"You give {count} tangos pos1");
		}

		public override void standAfk()
		{
			Console.WriteLine("GG WP");
		}
	}
}
