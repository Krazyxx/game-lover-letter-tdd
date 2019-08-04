using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<Card> Cards = new List<Card>();
		public int number;

		public Player(int numPlayer)
		{
			number = numPlayer;
		}
	}
}