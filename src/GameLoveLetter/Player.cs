using System;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<Card> Cards = new List<Card>();
		public int Number { get; set; }
		public bool IsProtected { get; set; }
		public bool IsEliminated { get; set; }

		public Player(int numPlayer)
		{
			Number = numPlayer;
			IsEliminated = false;
			IsProtected = false;
		}

		public Card PlayCard()
		{
			int index = 0;

			Card cardPlayed = Cards[index];
			Cards.RemoveAt(index);

			return cardPlayed;
		}
	}
}