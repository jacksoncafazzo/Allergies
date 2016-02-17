using Nancy;
using Nancy.ViewEngines.Razor;
using Narwhals;
using System;
using System.Collections.Generic;

namespace NarwhalParadiso
{
  public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
          return View["index.cshtml"];
        };
        Post["/panicmode"] = parameters => {
          int allergyScore = 0;
          List<CheckBoxList> checkedBoxes = new List<CheckBoxList>() {};
          foreach (CheckBox checkbox in Request.Form["allgySuperstar"])
          {
            if (checkbox.Selected == true)
            {
              checkedBoxes.Add(checkbox);
            }
          }
          foreach (CheckBox checkbox in checkedBoxes)
          {
            allergyScore += checkbox.parameters.id;
          }
          Allergy newAllergy = new Allergy(0);
          allergyScore = newAllergy.AllgySuperdoom(allergyScore);
          return View["DDay.cshtml", newAllergy];
        };
      }
    }
  }
