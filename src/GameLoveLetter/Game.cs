using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoveLetter
{
	public class Game
	{
		public List<Player> Players = new List<Player>();
		public Queue<Card> Cards;

		public Game(int nbPlayer)
		{
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				throw new UncorrectNumberOfPlayersException("A game must contain between 2 and 4 players.");
			}

			Players = new List<Player>();
			for (int i = 0; i < nbPlayer; i++)
			{
				Players.Add(new Player());
			}

			Cards = new Queue<Card>();
			Cards.Enqueue(new Guard());
			Cards.Enqueue(new Guard());
			Cards.Enqueue(new Guard());
			Cards.Enqueue(new Guard());
			Cards.Enqueue(new Guard());
			Cards.Enqueue(new Priest());
			Cards.Enqueue(new Priest());
			Cards.Enqueue(new Baron());
			Cards.Enqueue(new Baron());
			Cards.Enqueue(new Handmaid());
			Cards.Enqueue(new Handmaid());
			Cards.Enqueue(new Prince());
			Cards.Enqueue(new Prince());
			Cards.Enqueue(new King());
			Cards.Enqueue(new Countess());
			Cards.Enqueue(new Princess());

			Cards.Shuffle();
		}

		public void DiscardCard()
		{
			Cards.Dequeue();
		}

		public void Initialisation()
		{
			DiscardCard();

			foreach(var player in Players)
			{
				player.Cards.Add(Cards.Dequeue());
			}
		}
	}

	public static class EnumerableExtensions
	{ 
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> enumerable)
		{
			var r = new Random();
			return enumerable.OrderBy(x => r.Next()).ToList();
		}
	}
}
