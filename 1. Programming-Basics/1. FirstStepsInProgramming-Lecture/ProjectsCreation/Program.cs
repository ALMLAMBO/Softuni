using System;

namespace ProjectsCreation {
	class Program {
		static void Main(string[] args) {
			string name = Console.ReadLine();
			int projects = int.Parse(Console.ReadLine());

			Console.WriteLine(
				"The architect {0} will need {1} hours to complete {2} project/s.", 
				name, projects * 3, projects);
		}
	}
}
