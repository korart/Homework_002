namespace Homework_002
{
	internal abstract class Animal
	{
		private int health = 100;

		public int Health
		{
			get
			{
				return health;
			}
		}


		private string? name;
		public string Name
		{
			get
			{
				return name ?? "UNDEFINED";
			}
			set
			{
				if (String.IsNullOrEmpty(name))
				{
					name = value;
				}
				else
				{
					throw new InvalidOperationException("Value already set");
				}
			}
		}


		public required int Age { get; init; }


		public void Feed(int foodCount)
		{
			if (health + foodCount <= 100)
			{
				health += foodCount;
			}
			else
			{
				health = 100;
			}
		}
		public void Punish(int punchCount)
		{
			if (health - punchCount >= 0)
			{
				health -= punchCount;
			}
			else
			{
				health = 0;
			}
		}
		public virtual string Say()
		{
			return $"My name is {Name}, I'm {Age} year(s) old.";
		}
	}
}
