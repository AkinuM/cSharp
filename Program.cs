﻿using System;
using System.Collections.Generic;

namespace Snake
{
	class Program
	{
		static void DrawItem(Tuple<int, int> Item, ConsoleColor Background, string Symbol)
		{
			Console.SetCursorPosition(Item.Item1 * 2, Item.Item2);
			Console.BackgroundColor = Background;
			Console.Write(Symbol);
		}
		static int Game()
		{
			int Width = 25;
			int Height = 25;
			int Score = 1;
			double Speed = 10;

			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			for (int i = 0; i < Height; ++i)
			{
				for (int j = 0; j < Width; ++j)
				{
					Console.Write("  ");
				}
				Console.WriteLine();
			}
			Console.SetCursorPosition(Width * 2 + 10, 1);
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("Score: 1");
			Random Rand = new Random();
			List<Tuple<int, int>> Snake = new List<Tuple<int, int>>();
			Snake.Add(new Tuple<int, int>(Rand.Next(Width), Rand.Next(Height)));
			bool Lose = false;
			int Direction = 0;
			ConsoleKeyInfo Button;
			bool AppleExist = false;
			bool Hungry = true;
			string Eyes = "";
			Tuple<int, int> Apple = new Tuple<int, int>(0, 0);
			while (!Lose)
			{
				if (!AppleExist)
				{
					do
					{
						AppleExist = true;
						Apple = new Tuple<int, int>(Rand.Next(Width), Rand.Next(Height));
						for (int i = 0; i < Snake.Count; ++i)
						{
							if (Apple.Item1 == Snake[i].Item1 && Apple.Item2 == Snake[i].Item2)
							{
								AppleExist = false;
								break;
							}
						}
					} while (!AppleExist);
					DrawItem(Apple, ConsoleColor.DarkRed, "  ");
				}
				if (Console.KeyAvailable)
				{
					Button = Console.ReadKey(true);
					switch (Button.Key)
					{
						case ConsoleKey.S:
							if (Direction != 2)
							{
								Direction = 0;
							}
							break;
						case ConsoleKey.A:
							if (Direction != 3)
							{
								Direction = 1;
							}
							break;
						case ConsoleKey.W:
							if (Direction != 0)
							{
								Direction = 2;
							}
							break;
						case ConsoleKey.D:
							if (Direction != 1)
							{
								Direction = 3;
							}
							break;
					}
				}
				for (int i = Snake.Count - 1; i > 0; --i)
				{
					Snake[i] = Snake[i - 1];
				}
				if (Snake.Count > 1)
				{
					DrawItem(Snake[1], ConsoleColor.DarkGreen, "  ");
				}
				if (Snake[0].Item1 == Apple.Item1 && Snake[0].Item2 == Apple.Item2)
				{
					Snake.Add(Apple);
					AppleExist = false;
					Hungry = false;
					Console.SetCursorPosition(Width * 2 + 17, 1);
					Console.BackgroundColor = ConsoleColor.DarkGray;
					Console.ForegroundColor = ConsoleColor.Black;
					Console.Write(++Score);
					Speed += 0.3;
				}
				switch (Direction)
				{
					case 0:
						if (Snake[0].Item2 < Height - 1)
						{
							Snake[0] = new Tuple<int, int>(Snake[0].Item1, Snake[0].Item2 + 1);
						}
						else
						{
							Snake[0] = new Tuple<int, int>(Snake[0].Item1, 0);
						}
						Eyes = "..";
						break;
					case 1:
						if (Snake[0].Item1 > 0)
						{
							Snake[0] = new Tuple<int, int>(Snake[0].Item1 - 1, Snake[0].Item2);
						}
						else
						{
							Snake[0] = new Tuple<int, int>(Width - 1, Snake[0].Item2);
						}
						Eyes = ": ";
						break;
					case 2:
						if (Snake[0].Item2 > 0)
						{
							Snake[0] = new Tuple<int, int>(Snake[0].Item1, Snake[0].Item2 - 1);
						}
						else
						{
							Snake[0] = new Tuple<int, int>(Snake[0].Item1, Height - 1);
						}
						Eyes = "''";
						break;
					case 3:
						if (Snake[0].Item1 < Width - 1)
						{
							Snake[0] = new Tuple<int, int>(Snake[0].Item1 + 1, Snake[0].Item2);
						}
						else
						{
							Snake[0] = new Tuple<int, int>(0, Snake[0].Item2);
						}
						Eyes = " :";
						break;
				}
				if (!Lose)
				{
					DrawItem(Snake[0], ConsoleColor.DarkGreen, Eyes);
					System.Threading.Thread.Sleep((int)(1000 / Speed));
					if (Hungry)
					{
						for (int i = 1; i < Snake.Count; ++i)
						{
							if (Snake[0].Item1 == Snake[i].Item1 && Snake[0].Item2 == Snake[i].Item2)
							{
								Lose=true;
							}
						}
						DrawItem(Snake[Snake.Count - 1], ConsoleColor.Black, "  ");
					}
					else
					{
						Hungry = true;
					}
				}
			}
			return Score;
		}
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 30);
			Console.SetBufferSize(80, 30);
			Console.CursorVisible = false;
			int Score = 0;
			while (true)
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Clear();
				Console.SetCursorPosition(Console.BufferWidth / 2 - Convert.ToString("Score: " + Score).Length / 2, Console.BufferHeight / 2 + 1);
				Console.Write("Sсore: " + Score);
				Console.BackgroundColor = ConsoleColor.DarkYellow;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(Console.BufferWidth / 2 - 2, Console.BufferHeight / 2);
				Console.Write("Play");
				Console.BackgroundColor = ConsoleColor.Black;
				ConsoleKeyInfo Button;
				do
				{
					Button = Console.ReadKey(true);
				} while (Button.Key != ConsoleKey.Enter);
				Score = Game();
				Console.SetCursorPosition(Console.BufferWidth / 2 - 5, Console.BufferHeight / 2);
				Console.BackgroundColor = ConsoleColor.DarkYellow;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("You Looser))");
				do
				{
					Button = Console.ReadKey(true);
				} while (Button.Key != ConsoleKey.Enter);
			}
		}
	}
}