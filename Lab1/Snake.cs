using System;
using System.Collections.Generic;

namespace Snake
{
	class Program
	{
		static void DrawItem(Tuple<int, int> item, ConsoleColor background, string symbol)
		{
			Console.SetCursorPosition(item.Item1 * 2, item.Item2);
			Console.BackgroundColor = background;
			Console.Write(symbol);
		}
		static int Game()
		{
			int width = 25;
			int height = 25;
			int score = 1;
			double speed = 10;

			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			for (int i = 0; i < height; ++i)
			{
				for (int j = 0; j < width; ++j)
				{
					Console.Write("  ");
				}
				Console.WriteLine();
			}
			Console.SetCursorPosition(width * 2 + 10, 1);
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("Score: 1");
			Random rand = new Random();
			List<Tuple<int, int>> snake = new List<Tuple<int, int>>();
			snake.Add(new Tuple<int, int>(rand.Next(width), rand.Next(height)));
			bool lose = false;
			int direction = 0;
			ConsoleKeyInfo button;
			bool appleExist = false;
			bool hungry = true;
			string eyes = "";
			Tuple<int, int> apple = new Tuple<int, int>(0, 0);
			while (!lose)
			{
				if (!appleExist)
				{
					while (!appleExist)
					{
						appleExist = true;
						apple = new Tuple<int, int>(rand.Next(width), rand.Next(height));
						for (int i = 0; i < snake.Count; ++i)
						{
							if (apple.Item1 == snake[i].Item1 && apple.Item2 == snake[i].Item2)
							{
								appleExist = false;
								break;
							}
						}
					}
					DrawItem(apple, ConsoleColor.DarkRed, "  ");
				}
				if (Console.KeyAvailable)
				{
					button = Console.ReadKey(true);
					switch (button.Key)
					{
						case ConsoleKey.S:
							if (direction != 2)
							{
								direction = 0;
							}
							break;
						case ConsoleKey.A:
							if (direction != 3)
							{
								direction = 1;
							}
							break;
						case ConsoleKey.W:
							if (direction != 0)
							{
								direction = 2;
							}
							break;
						case ConsoleKey.D:
							if (direction != 1)
							{
								direction = 3;
							}
							break;
					}
				}
				for (int i = snake.Count - 1; i > 0; --i)
				{
					snake[i] = snake[i - 1];
				}
				if (snake.Count > 1)
				{
					DrawItem(snake[1], ConsoleColor.DarkGreen, "  ");
				}
				if (snake[0].Item1 == apple.Item1 && snake[0].Item2 == apple.Item2)
				{
					snake.Add(apple);
					appleExist = false;
					hungry = false;
					Console.SetCursorPosition(width * 2 + 17, 1);
					Console.BackgroundColor = ConsoleColor.DarkGray;
					Console.ForegroundColor = ConsoleColor.Black;
					Console.Write(++score);
					speed += 0.3;
				}
				switch (direction)
				{
					case 0:
						if (snake[0].Item2 < height - 1)
						{
							snake[0] = new Tuple<int, int>(snake[0].Item1, snake[0].Item2 + 1);
						}
						else
						{
							snake[0] = new Tuple<int, int>(snake[0].Item1, 0);
						}
						eyes = "..";
						break;
					case 1:
						if (snake[0].Item1 > 0)
						{
							snake[0] = new Tuple<int, int>(snake[0].Item1 - 1, snake[0].Item2);
						}
						else
						{
							snake[0] = new Tuple<int, int>(width - 1, snake[0].Item2);
						}
						eyes = ": ";
						break;
					case 2:
						if (snake[0].Item2 > 0)
						{
							snake[0] = new Tuple<int, int>(snake[0].Item1, snake[0].Item2 - 1);
						}
						else
						{
							snake[0] = new Tuple<int, int>(snake[0].Item1, height - 1);
						}
						eyes = "''";
						break;
					case 3:
						if (snake[0].Item1 < width - 1)
						{
							snake[0] = new Tuple<int, int>(snake[0].Item1 + 1, snake[0].Item2);
						}
						else
						{
							snake[0] = new Tuple<int, int>(0, snake[0].Item2);
						}
						eyes = " :";
						break;
				}
				if (!lose)
				{
					DrawItem(snake[0], ConsoleColor.DarkGreen, eyes);
					System.Threading.Thread.Sleep((int)(1000 / speed));
					if (hungry)
					{
						for (int i = 1; i < snake.Count; ++i)
						{
							if (snake[0].Item1 == snake[i].Item1 && snake[0].Item2 == snake[i].Item2)
							{
								lose=true;
							}
						}
						DrawItem(snake[snake.Count - 1], ConsoleColor.Black, "  ");
					}
					else
					{
						hungry = true;
					}
				}
			}
			return score;
		}
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 30);
			Console.SetBufferSize(80, 30);
			Console.CursorVisible = false;
			int score = 0, lastScore = 0;
			while (true)
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Clear();
				Console.SetCursorPosition(Console.BufferWidth / 2 - Convert.ToString("Score: " + score).Length / 2, Console.BufferHeight / 2 + 1);
				Console.Write("Sсore: " + score);
				Console.BackgroundColor = ConsoleColor.DarkYellow;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(Console.BufferWidth / 2 - 2, Console.BufferHeight / 2);
				Console.Write("Play");
				Console.BackgroundColor = ConsoleColor.Black;
				ConsoleKeyInfo Button;
				do
				{
					Button = Console.ReadKey(true);
				}
				while (Button.Key != ConsoleKey.Enter);
				lastScore = Game();
				if (lastScore > score)
				{
					score = lastScore;
				}
				Console.SetCursorPosition(Console.BufferWidth / 2 - 5, Console.BufferHeight / 2);
				Console.BackgroundColor = ConsoleColor.DarkYellow;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("You Looser))");
				do
				{
					Button = Console.ReadKey(true);
				}
				while (Button.Key != ConsoleKey.Enter);
			}
		}
	}
}
