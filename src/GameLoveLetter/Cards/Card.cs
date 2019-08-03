namespace GameLoveLetter
{
	public class Card
	{
		public string Name { get; private set; }
		public int Strength { get; private set; }

		public Card(string name, int strength)
		{
			Name = name;
			Strength = strength;
		}
	}
}