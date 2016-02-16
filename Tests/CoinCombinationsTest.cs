using Xunit;

namespace CoinReturner
{
  public class CoineyTest
  {
    [Fact]
    public void CoinsReturned_WillReturnTotalAmaountDividedByOne_true()
    {
      Coiney newCoiney = new Coiney();
      Assert.Equal(14, newCoiney.CoinsReturned(14));
    }
    [Fact]
    public void CoinsReturned_WillReturnTotalAmaountDividedByFive_true()
    {
      Coiney newCoiney = new Coiney();
      Assert.Equal(4, newCoiney.CoinsReturned(23));
    }
  }
}
