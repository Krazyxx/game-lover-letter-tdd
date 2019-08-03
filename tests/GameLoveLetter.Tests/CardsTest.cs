using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardsTest
	{
		[Fact]
		public void CheckNameAndStrengthOfCards()
		{
			//A
			var cardGuard = new Guard();
			var cardGuardName = "Guard";
			var cardGuardStrength = 1;

			var cardPriest = new Priest();
			var cardPriestName = "Priest";
			var cardPriestStrength = 2;

			var cardBaron = new Baron();
			var cardBaronName = "Baron";
			var cardBaronStrength = 3;

			var cardHandmaid = new Handmaid();
			var cardHandmaidName = "Handmaid";
			var cardHandmaidStrength = 4;

			var cardPrince = new Prince();
			var cardPrinceName = "Prince";
			var cardPrinceStrength = 5;

			var cardKing = new King();
			var cardKingName = "King";
			var cardKingStrength = 6;

			var cardCountess = new Countess();
			var cardCountessName = "Countess";
			var cardCountessStrength = 7;

			var cardPrincess = new Princess();
			var cardPrincessName = "Princess";
			var cardPrincessStrength = 8;

			//A
			Assert.Equal(cardGuardName, cardGuard.Name);
			Assert.Equal(cardGuardStrength, cardGuard.Strength);

			Assert.Equal(cardPriestName, cardPriest.Name);
			Assert.Equal(cardPriestStrength, cardPriest.Strength);

			Assert.Equal(cardBaronName, cardBaron.Name);
			Assert.Equal(cardBaronStrength, cardBaron.Strength);

			Assert.Equal(cardHandmaidName, cardHandmaid.Name);
			Assert.Equal(cardHandmaidStrength, cardHandmaid.Strength);

			Assert.Equal(cardPrinceName, cardPrince.Name);
			Assert.Equal(cardPrinceStrength, cardPrince.Strength);

			Assert.Equal(cardKingName, cardKing.Name);
			Assert.Equal(cardKingStrength, cardKing.Strength);

			Assert.Equal(cardCountessName, cardCountess.Name);
			Assert.Equal(cardCountessStrength, cardCountess.Strength);

			Assert.Equal(cardPrincessName, cardPrincess.Name);
			Assert.Equal(cardPrincessStrength, cardPrincess.Strength);
		}
	}
}
