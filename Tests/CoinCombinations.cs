namespace CoinReturner
{
  public class Coiney
  {
    public int CoinsReturned(int change)
    {
      if (change % 1 == 0)
      {
        return change;
      }
      else
      {
        return 0;
      }
    }
  }
}
    // private int _change;
    // // private int _cents;
    // // private int _nickels;
    // // private int _dimes;
    // // private int _quarters;
    //
    // public Coiney(int change)
    // {
    //   _change = change;
    //   // _cents;
    // }
    // public int GetChange()
    // {
    //   return _change;
    // }
