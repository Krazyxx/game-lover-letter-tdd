using System;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<Card> Cards = new List<Card>();
		public int Number = 0;
		public bool IsEliminated = false;

		public Player(int numPlayer)
		{
			Number = numPlayer;
		}

		public void Eliminate()
		{
			IsEliminated = true;
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