namespace Homework_002
{
	internal class Dog : Animal
	{
		public override string Say()
		{
			return base.Say() + " Woof!";
		}
	}
}
