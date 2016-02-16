using Nancy;
using CoineyCoins.Objects;
using System;
using System.Collections.Generic;

namespace CoinReturner
{
  public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
          return View["index.cshtml"];
        };
        Post["/feed_coiney"] =_=>{
            Coiney newCoiney = new Coiney();
            decimal[] change = newCoiney.CoinsReturned(Request.Form["coin-return"]);
            return View["final_result.cshtml", change];
        };

      }
    }
  }
