using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
  public class VisualBezier : VisualCurve
  {
    public VisualBezier(Bezier _curve) : base(_curve)
    {
      n = 20;
    }
  }
}
