using System;
using System.Collections.Generic;
using Nancy;
using Leetspeak.Objects;

namespace Leetspeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["input.cshtml"];
      Post["/"] = _ => {
        L33t instance = new L33t();
        string output = instance.Convert(instance.MakeLeet(Request.Form["input"]));
        return View["output.cshtml", output];
      };
    }
  }
}
