using System;

namespace Narwhals
{
  public class Allergy
  {
    private int _allgy;
    private static int _total;
    public Allergy(int allgy, int total)
    {
      _allgy = allgy;
      _total = total;
    }

    public int GetTotal()
    {
      return _total;
    }
    public int GetAllgy()
    {
      return _allgy;
    }
    public void SetAllgy(int allgy)
    {
      _allgy = allgy;
    }

    public static void SetTotal(int total)
    {
      _total = total;
    }
    public static void AddToTotal(int allgy)
    {
      _total = _total + allgy;
    }

    public void AllgySuperdoom()
    {
      int allgy = this.GetAllgy();
      string[] AllgyArray = new string[] { "eggs", "peanuts", "shellfish", "tomatoes", "chocolate", "pollen", "cats" };
      int[] FinalArray = new int[] { 1, 2, 4, 8 , 16, 32, 64, 128 };
      Allergy.AddToTotal(FinalArray[allgy]);
    }
  }
}
