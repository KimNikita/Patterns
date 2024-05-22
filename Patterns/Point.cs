using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
  public class Point : IPoint
  {
    private double x;
    private double y;
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
  }
}
