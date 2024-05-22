using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
  public abstract class ACurve : ICurve
  {
    protected IPoint a;
    protected IPoint b;

    public ACurve(IPoint _a, IPoint _b)
    {
      a = _a;
      b = _b;
    }

    public abstract void GetPoint(double t, out IPoint p);
  }
}
