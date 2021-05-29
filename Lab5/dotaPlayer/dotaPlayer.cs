using System;

namespace dotaPlayer
{
	abstract class dotaPlayer : SteamUser
	{
		enum result 
		{
			win, lost
		}

		protected int mmr;
		public int MMR
		{
			get
			{
				return mmr;
			}
		}

		protected int role;
		public int Role
		{
			get
			{
				return role;
			}
		}

		public abstract void playGame(string hero, string line);

		protected string hero;

		protected string line;

		protected string[] items = new string[9];
		protected void buyItem()
		{
			Console.Write("Change slot: ");
			int index = Convert.ToInt32(Console.ReadLine());
			Console.Write("\nChange item: ");
			string item = Console.ReadLine();
			items[index] = item;
		}

		protected bool gameResult()
		{
			Random rndResult = new Random();
			if (rndResult.Next(0,1) == (int)result.win)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public virtual void standAfk()
		{
			Console.WriteLine("Good game");
		}
		
		public delegate void chat();

		public void writeToChat(chat writeMessage)
		{
			Console.Write($"{profileName}: ");
			writeMessage?.Invoke();
		}

		public delegate void game();

		public event game endGame;

		public void endGameMessage()
		{
			Console.WriteLine("Game was over");
		}
	}
}
