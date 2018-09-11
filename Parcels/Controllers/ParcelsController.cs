using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;
using System;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/Parcels/Add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/List")]
    public ActionResult List()
    {
      Parcel newpack = new Parcel();
      newpack.Length = float.Parse((Request.Form["parcelL"]));
      newpack.Width = float.Parse((Request.Form["parcelW"]));
      newpack.Height = float.Parse((Request.Form["parcelH"]));
      newpack.CalcVolume();
      newpack.Save();
      List<Parcel> allPackages = Parcel.GetAll();

      return View("List", allPackages);
    }


  }
}
