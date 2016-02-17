using Nancy;
using Narwhals;
using System;
using System.Collections.Generic;

namespace Allergies
{
  public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
          return View["index.cshtml"];
        };
        Post["/panicmode"] =_=>{
          Allergy newAllergy = new Allergy(Request.Form["doom"], 0);
          newAllergy.AllgySuperdoom();
          return View["DDay.cshtml", newAllergy];
        };
      }
    }
  }
