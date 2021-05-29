using System;

namespace dotaPlayer
{
	class pos1DotaPlayer : dotaPlayer
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
			Console.WriteLine("Do you want to break tower?");
			string change2 = Console.ReadLine();
			if (change2 == "yes")
			{
				breakTower();
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

		public pos1DotaPlayer()
		{
			Console.Write("Enter your MMR: ");
			mmr = Convert.ToInt32(Console.ReadLine());
			role = 5;
		}

		private void breakTower()
		{
			Random rndResult = new Random();
			if (rndResult.Next(0, 1) == 1)
			{
				Console.WriteLine("You successfully break the tower!"); 
			}
			else
			{
				Console.WriteLine("you couldn't break the tower");
			}
		}

		public override void standAfk()
		{
			Console.WriteLine("So bad team");
		}
	}
}
