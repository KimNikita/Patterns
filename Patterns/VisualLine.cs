using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
  public class VisualLine : VisualCurve
  {
    public VisualLine(Line _curve) : base(_curve)
    {
      n = 10;
    }
  }
}
