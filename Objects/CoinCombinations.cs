using System;

namespace CoineyCoins.Objects
{
  public class Coiney
  {

    public decimal[] CoinsReturned(string changeString)
    {
      decimal change = decimal.Parse(changeString);
      decimal[] coinsArray = new decimal[4];

      if (change % 25 != 0)
      {
        decimal changeDecimal = change / 25;
        decimal quartersRounded = Math.Floor(changeDecimal);
        coinsArray[3] = change % 5;
        change = change - (quartersRounded * 25);
        coinsArray[0] = quartersRounded;
      }
      else
      {
        coinsArray[0] = change / 25;
        change = 0;
      }
      if (change % 10 != 0)
      {
        decimal changeDecimal = change / 10;
        decimal dimesRounded = Math.Floor(changeDecimal);
        change = change - (dimesRounded * 10);
        coinsArray[1] = dimesRounded;
      }
      else
      {
        coinsArray[1] = change / 10;
        change = 0;
      }
      if (change % 5 != 0)
      {
        decimal changeDecimal = change / 5;
        coinsArray[2] = Math.Floor(changeDecimal);
      }
      else
      {
        Console.WriteLine("oh noes");
      }
      return coinsArray;
    }
  }
}
