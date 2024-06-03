using System.Text;

namespace Homework_002
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;


			Animal[] animals = InitAnimals();


			foreach (Animal animal in animals)
			{
				Test(animal);
				Console.WriteLine(animal.Say());
				ShowStatus(animal);
			}
		}

		static void Test(Animal a)
		{
			Random rand = new();

			if (a is Cat cat)
			{
				for (int i = 0; i < 10; i++)
				{
					cat.Punish(rand.Next(0, 60));
					cat.Feed(rand.Next(0, 60));
				}

			}

			if (a is Dog dog)
			{
				for (int i = 0; i < 5; i++)
				{
					dog.Punish(rand.Next(0, 50));
					dog.Feed(rand.Next(0, 50));
				}
			}

		}

		static void ShowStatus(Animal animal)
		{
			ConsoleColor fgColor = Console.ForegroundColor;

			Console.ForegroundColor = animal.Health < 51 ? ConsoleColor.Red : ConsoleColor.Green; // заменил белый на красный для наглядности

			string status = "";
			for (int i = 0; i < animal.Health / 10; i++)
			{
				status += "▋";
			}


			Console.WriteLine("Health: {0}", status);
			Console.ForegroundColor = fgColor;

		}

		static Animal[] InitAnimals()
		{
			Cat c1 = new() { Age = 5, Name = "Misty" };
			Cat c2 = new() { Age = 6 };
			Cat c3 = new() { Age = 7 };

			c2.Name = "Bella";

			Dog d1 = new() { Age = 1, Name = "Jax" };
			Dog d2 = new() { Age = 2 };
			Dog d3 = new() { Age = 3 };

			d2.Name = "Charlie";


			Animal[] animals = [c1, c2, d1, c3, d2, d3];

			c3.Name = "Lily";
			d3.Name = "Jack";

			return animals;
		}
	}
}
