using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardsTest
	{
		#region Check card's properties

		[Fact]
		public void CheckNameAndStrengthOfGuardCard()
		{
			// A
			var card = new Guard();
			var cardName = "Guard";
			var cardStrength = 1;

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfPriestCard()
		{
			// A
			var card = new Priest();
			var cardName = "Priest";
			var cardStrength = 2;

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfBaronCard()
		{
			// A
			var card = new Baron();
			var cardName = "Baron";
			var cardStrength = 3;

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfHandmaidCard()
		{
			// A
			var card = new Handmaid();
			var cardName = "Handmaid";
			var cardStrength = 4;

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfPrinceCard()
		{
			// A
			var card = new Prince();
			var cardPrinceName = "Prince";
			var cardPrinceStrength = 5;

			// A

			// A
			Assert.Equal(cardPrinceName, card.Name);
			Assert.Equal(cardPrinceStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfKingCard()
		{
			// A
			var card = new King();
			var cardName = "King";
			var cardStrength = 6;

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfCountessCard()
		{
			// A
			var card = new Countess();
			var cardName = "Countess";
			var cardStrength = 7;

			// A

			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		[Fact]
		public void CheckNameAndStrengthOfPrincessCard()
		{
			// A
			var card = new Princess();
			var cardName = "Princess";
			var cardStrength = 8;

			// A
			
			// A
			Assert.Equal(cardName, card.Name);
			Assert.Equal(cardStrength, card.Strength);
		}

		#endregion // Check card's properties

	}
}
