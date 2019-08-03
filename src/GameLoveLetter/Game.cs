using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoveLetter
{
	public class Game
	{
		public List<Player> Players = new List<Player>();
		public Card[] Cards;

		public Game(int nbPlayer)
		{
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				throw new UncorrectNumberOfPlayersException("A game must contain at least 2 players and less than 4 players.");
			}

			Players = new List<Player>();
			for (int i = 0; i < nbPlayer; i++)
			{
				Players.Add(new Player());
			}

			Cards = new Card[]
			{
				new Guard(),
				new Guard(),
				new Guard(),
				new Guard(),
				new Guard(),
				new Priest(),
				new Priest(),
				new Baron(),
				new Baron(),
				new Handmaid(),
				new Handmaid(),
				new Prince(),
				new Prince(),
				new King(),
				new Countess(),
				new Princess()
			};

		}
	}
}
