using Xunit;
using System;
using System.Collections.Generic;


namespace Narwhals
{

  public class allgydoomtest
  {
    [Fact]
    public void Test1_DoomsDayDevice_true()
    {
      List<string> allgys = new List<string>(){};
      allgys[0] = "eggs";
      allgys[1] = "peanuts";
      allgys[2] = "shellfish";
      allgys[3] = "strawberries";
      //Arrange
      Allergy newAllergy = new Allergy(0);
    //Assert
      newAllergy = newAllergy.AllgySuperdoom(8);
      Assert.Equal(allgys, Allergy.GetAllgys());
    }
  }
}
