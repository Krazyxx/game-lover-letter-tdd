using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class GameTest
	{
		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		[InlineData(5)]
		public void GameHasTwoToFourPlayers(int nbPlayer)
		{
			// A
			UncorrectNumberOfPlayersException exception = null;

			// A
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				exception = Assert.Throws<UncorrectNumberOfPlayersException>(() => new Game(nbPlayer));
			}

			// A
			if (nbPlayer >= 2 && nbPlayer <= 4)
			{
				Assert.Null(exception);
			}
			else
			{
				Assert.NotNull(exception);
				Assert.Equal("A game must contain between 2 and 4 players.", exception.Message);
			}
		}

		[Fact]
		public void AGameHasSixteenCards()
		{
			// A
			var game = new Game(2);

			// A
			var nbCards = 16;

			// A
			Assert.Equal(game.Cards.Count, nbCards);
		}

		[Fact]
		public void AGameHasFiveGuardsTwoPriestsTwoBaronsTwoHandmaidsTwoPrincesOneKingOneCountessAndOnePrincess()
		{
			// A
			var game = new Game(2);

			int nbGuards = 5;
			int nbPriests = 2;
			int nbBarons = 2;
			int nbHandmaids = 2;
			int nbPrinces = 2;
			int nbKings = 1;
			int nbCountesses = 1;
			int nbPrincesses = 1;
			int nbOthersCards = 0;

			// A
			foreach (var card in game.Cards)
			{
				switch (card.Name)
				{
					case "Guard":
						nbGuards--;
						break;
					case "Priest":
						nbPriests--;
						break;
					case "Baron":
						nbBarons--;
						break;
					case "Handmaid":
						nbHandmaids--;
						break;
					case "Prince":
						nbPrinces--;
						break;
					case "King":
						nbKings--;
						break;
					case "Countess":
						nbCountesses--;
						break;
					case "Princess":
						nbPrincesses--;
						break;
					default:
						nbOthersCards--;
						break;
				}
			}

			int expectedCount = 0;

			// A
			Assert.Equal(expectedCount, nbGuards);
			Assert.Equal(expectedCount, nbPriests);
			Assert.Equal(expectedCount, nbBarons);
			Assert.Equal(expectedCount, nbHandmaids);
			Assert.Equal(expectedCount, nbPrinces);
			Assert.Equal(expectedCount, nbKings);
			Assert.Equal(expectedCount, nbCountesses);
			Assert.Equal(expectedCount, nbPrincesses);
			Assert.Equal(expectedCount, nbOthersCards);
		}

		[Theory]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		public void OneCardIsDiscardedAtTheBeginning(int nbPlayer)
		{
			// A
			var game = new Game(nbPlayer);
			int nbCards = 16;

			// A
			game.DiscardCard();
			nbCards--;

			// A
			Assert.Equal(nbCards, game.Cards.Count);
		}

		[Theory]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		public void DuringInitialisationOneCardIsDiscardedAndOneCardIsDealtToEachPlayer(int nbPlayer)
		{
			// A
			var game = new Game(nbPlayer);
			var nbCards = 16;
			var nbDiscardedCards = 1;
			var nbCardsExpectedPerPlayer = 1;
			var nbCardsExpected = nbCards - nbDiscardedCards - nbPlayer;

			// A
			game.Initialization();

			// A
			Assert.Equal(nbCardsExpected, game.Cards.Count);
			foreach (var player in game.Players)
			{
				Assert.Equal(nbCardsExpectedPerPlayer, player.Cards.Count);
			}
		}

		[Theory]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		public void PlayerHasOnlyOneCardAfterHisTurnExceptIfHeIsEliminated(int nbPlayer)
		{
			// A
			var game = new Game(nbPlayer);
			game.Initialization();

			int[] nbCardPerPlay = new int[nbPlayer];
			int nbCardsExpected = 1;
			int nbRemainingCardsExpected = game.Cards.Count - nbPlayer;

			// A
			foreach (var player in game.Players)
			{
				game.PlayTurn(player);
				nbCardPerPlay[player.Number] = player.Cards.Count;
			}

			// A
			foreach (var player in game.Players)
			{
				if (!player.IsEliminated)
				{
					Assert.Equal(nbCardsExpected, nbCardPerPlay[player.Number]);
				}
			}

			Assert.Equal(nbRemainingCardsExpected, game.Cards.Count);
		}
	}
}
