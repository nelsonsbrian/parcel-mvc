using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;
using System;

namesapce Parcel.Controllers
{
  public class ParcelController : Controllers
  {

    [HttpGet("/Add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/List")]
    public ActionResult List()
    {
      Parcel newpack = new Parcel()
      newpack.Length = (Request.Form["parcelL"]);
      newpack.Width = (Request.Form["parcelW"]);
      newpack.Height = (Request.Form["parcelH"]);
      newpack.Save();
      List<Parcel> allPackages = Parcel.GetAll();
      return View("List", allPackages);
    }


  }
}
