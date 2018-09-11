using System;
using System.Collections.Generic;

namespace Parcel.Models
{
  public class Parcel
  {
    // private float _length;
    // private float _width;
    // private float _height;
    private float _volume;
    private float _costToShip;
    private static List<Parcel> _packages = new List<Parcel> {};

    // public Parcel(float length, float width, float height)
    // {
    //   _length = length;
    //   _width = width;
    //   _height = height;
    // }

    public Parcel()
    {

    }

    public float Length { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }

    public void CalcVolume()
    {
      _volume = Parcel.Length * Parcel.Width * Parcel.Height;
    }

    public void Save()
    {
      _packages.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _packages;
    }

    public static void ClearAll()
    {
      _packages.Clear();
    }
  }
}
