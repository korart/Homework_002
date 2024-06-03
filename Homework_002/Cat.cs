namespace Homework_002
{
	internal class Cat : Animal
	{
		public override string Say()
		{
			return base.Say() + " Meow!";
		}
	}
}
