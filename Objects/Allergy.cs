using System;
using System.Collections.Generic;

namespace Narwhals
{
  public class Allergy
  {
    private int _allgy;
    private static List<string> _allgys = new List<string>() {};
    private static Dictionary<string, int> _allgyScore = new Dictionary<string, int>() {
      {"eggs", 1},
      {"peanuts", 2},
      {"shellfish", 4},
      {"strawberries", 8},
      {"tomatoes", 16},
      {"chocolate", 32},
      {"pollen", 64},
      {"cats", 128},
    };
    public Allergy(int allgy)

    {
      _allgy = allgy;
    }
    public int GetAllgy()
    {
      return _allgy;
    }
    public void SetAllgy(int allgy)
    {
      _allgy = allgy;
    }
    public static List<string> GetAllgys()
    {
      return _allgys;
    }
    public static void SetAllgys(List<string> allgys)
    {
      _allgys = allgys;
    }
    public static Dictionary<string, int> GetScores()
    {
      return _allgyScore;
    }
    // public static List<string> SelectedValuesAsStrings(this CheckBoxList thatCheckBoxList )
    // {
    //   List<string> selectedValuesAsStrings = thatCheckBoxList.Items
    //                   .Cast<ListItem>()
    //                   .Where( i => i.Selected )
    //                   .Select( i => i.Value )
    //                   .ToList();
    //
    //   return selectedValuesAsStrings;
    // }

    public Allergy AllgySuperdoom(int userAllgy)
    {
      this.SetAllgy(userAllgy);
      Dictionary<string, int> allgyScore = Allergy.GetScores();
      List<string> allgys = new List<string>();
      foreach (KeyValuePair<string, int> allgy in allgyScore)
      {
        if (allgy.Value <= this.GetAllgy())
        {
          allgys.Add(allgy.Key);
          Console.WriteLine(allgy.Key);
        }
      }
      Allergy.SetAllgys(allgys);

      return this;
    }
  }
}
