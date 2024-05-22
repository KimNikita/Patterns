using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Visual
{
  public abstract class VisualCurve : IDrawable, ICurve
  {
    protected ICurve curve;
    protected int n;
    public VisualCurve(ICurve _curve)
    {
      curve = _curve;
    }

    public void Draw(IDrawer drawer)
    {
      if (drawer is ACurveDrawer)
        DrawCurve((ACurveDrawer)drawer);
      return;
    }

    protected void DrawCurve(ACurveDrawer drawer)
    {
      drawer.DrawFirstPoint(curve);
      drawer.DrawLastPoint(curve);

      for (int i = 1; i <= n; i++)
      {
        double t1 = (double)(i - 1) / n;
        double t2 = (double)i / n;
        drawer.DrawSegment(curve, t1, t2);
      }
    }

    public void GetPoint(double t, out IPoint p)
    {
      curve.GetPoint(t, out p);
    }
  }
}
