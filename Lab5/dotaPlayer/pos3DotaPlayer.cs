using System;

namespace dotaPlayer
{
	class pos3DotaPlayer : dotaPlayer
	{
		public override void playGame(string changeHero, string changeLine)
		{
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
			Console.WriteLine("Do you want to kill enemy pos1?");
			string change2 = Console.ReadLine();
			if (change2 == "yes")
			{
				killEnemypos1();
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

		public pos3DotaPlayer()
		{
			Console.Write("Enter your MMR: ");
			mmr = Convert.ToInt32(Console.ReadLine());
			role = 5;
		}

		private void killEnemypos1()
		{
			Random rndResult = new Random();
			if (rndResult.Next(0, 1) == 1)
			{
				Console.WriteLine("You successfully killed enemy pos1!");
			}
			else
			{
				Console.WriteLine("You couldn't kill enemy pos1");
			}
		}

		private void standAfk()
		{
			Console.WriteLine("End game pls");
		}
	}
}
