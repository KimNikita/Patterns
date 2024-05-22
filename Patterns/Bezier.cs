using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
  public class Bezier : ACurve
  {
    private IPoint c;
    private IPoint d;
    public Bezier(IPoint _a, IPoint _b, IPoint _c, IPoint _d) : base(_a, _b)
    {
      c = _c;
      d = _d;
    }

    public override void GetPoint(double t, out IPoint p)
    {
      p = new Point();
      p.X = (1 - t) * (1 - t) * (1 - t) * a.X + 3 * t * (1 - t) * (1 - t) * c.X + 3 * t * t * (1 - t) * d.X + t * t * t * b.X;
      p.Y = (1 - t) * (1 - t) * (1 - t) * a.Y + 3 * t * (1 - t) * (1 - t) * c.Y + 3 * t * t * (1 - t) * d.Y + t * t * t * b.Y;
    }
  }
}
