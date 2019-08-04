using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace GameLoveLetter.Tests
{

	public class CardTestData : IEnumerable<object[]>
	{
		private readonly List<object[]> _data = new List<object[]>
		{
			new object[] { new Guard(),		"Guard",	1 },
			new object[] { new Priest(),	"Priest",	2 },
			new object[] { new Baron(),		"Baron",	3 },
			new object[] { new Handmaid(),	"Handmaid", 4 },
			new object[] { new Prince(),	"Prince",	5 },
			new object[] { new King(),		"King",		6 },
			new object[] { new Countess(),	"Countess", 7 },
			new object[] { new Princess(),	"Princess", 8 }
		};

		public IEnumerator<object[]> GetEnumerator()
		{
			return _data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public class CardsTest
	{
		[Theory]
		[ClassData(typeof(CardTestData))]
		public void CheckNameAndStrengthOfCards(Card card, string cardName, int cardStrength)
		{
			// A

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void WhenPlayerPlaysPrincessCardHeIsEliminated()
		{
			// A
			var game = new Game(3);
			game.Initialization();
			game.Players[0].Cards = new List<Card> { new Princess() };

			// A
			game.PlayTurn(game.Players[0]);

			// A
			Assert.True(game.Players[0].IsEliminated);
		}

		[Fact]
		public void WhenPlayerPlaysPrincessCardHeIsProtected()
		{
			// A
			var game = new Game(3);
			game.Initialization();
			game.Players[0].Cards = new List<Card> { new Handmaid() };

			// A
			game.PlayTurn(game.Players[0]);

			// A
			Assert.True(game.Players[0].IsProtected);
		}

		[Fact]
		public void WhenPlayerPlaysBaronCardHeChooseAnotherPlayerAndCompareHands()
		{
			// A
			var game = new Game(2);
			game.Initialization();
			game.Players[0].Cards = new List<Card> { new Handmaid() };

			// A
			game.PlayTurn(game.Players[0]);

			// A
			Assert.True(game.Players[0].IsProtected);
		}

		[Fact]
		public void WhenPlayerPlaysGuardCardHeDesignatesAnotherPlayerAndNamesATypeOfCard()
		{
			// A
			var game = new Game(3);
			game.Initialization();
			game.Players[0].Cards = new List<Card> { new Guard() };

			// A
			game.PlayTurn(game.Players[0]);

			// A
			// TODO : Implement this.
		}
	}
}
