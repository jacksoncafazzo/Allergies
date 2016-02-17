using Xunit;
using System;


namespace Narwhals
{

  public class allgydoomtest
  {
    [Fact]
    public void Test1_DoomsDayDevice_true()
    {
      //Arrange
      Allergy newAllergy = new Allergy(3, 0);
      newAllergy.AllgySuperdoom();
    //Assert
      Assert.Equal(8, newAllergy.GetTotal());
    }
  }
}
