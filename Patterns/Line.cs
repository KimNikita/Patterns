using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
  public class Line : ACurve
  {
    public Line(IPoint _a, IPoint _b) : base(_a, _b) { }

    public override void GetPoint(double t, out IPoint p)
    {
      p = new Point();
      p.X = (1 - t) * a.X + t * b.X;
      p.Y = (1 - t) * a.Y + t * b.Y;
    }
  }
}
