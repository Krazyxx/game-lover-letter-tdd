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
				Players.Add(new Player(i));
			}

			IEnumerable<Card> tmpCards = new List<Card>()
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

			tmpCards = tmpCards.Shuffle();

			Cards = new Queue<Card>();
			foreach (var card in tmpCards)
			{
				Cards.Enqueue(card);
			}
		}

		public void DiscardCard()
		{
			var discardedCard = Cards.Dequeue();
			Console.WriteLine($"Discard top card ({discardedCard.Name} card).");
		}

		public void Initialization()
		{
			DiscardCard();

			Console.WriteLine("Deal card to each player :");
			foreach (var player in Players)
			{
				DrawACard(player);
			}
		}

		public void DrawACard(Player player)
		{
			player.Cards.Add(Cards.Dequeue());

			Console.WriteLine($"Player {player.Number} draw a {player.Cards[0].Name} card.");
		}

		public void PlayTurn(Player player)
		{
			DrawACard(player);
			Card cardPlayed = player.PlayCard();

			Console.WriteLine($"Player {player.Number} has play {cardPlayed.Name} card.");
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
