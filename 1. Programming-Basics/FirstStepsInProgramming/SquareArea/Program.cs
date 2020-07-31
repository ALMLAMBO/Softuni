using System;

namespace SquareArea {
	class Program {
		static void Main(string[] args) {
			int squareSize = int.Parse(Console.ReadLine());
			int area = (int) Math.Round(Math.Pow(squareSize, 2), 0);
			Console.WriteLine(area);
		}
	}
}
