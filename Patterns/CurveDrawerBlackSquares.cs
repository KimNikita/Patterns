using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;
using System.Drawing;

namespace Visual
{
  public class CurveDrawerBlackSquares : ACurveDrawer
  {
    public CurveDrawerBlackSquares(IContext _context) : base(_context) { }
    public override void DrawFirstPoint(ICurve curve)
    {
      int r = 5;
      IPoint p;
      curve.GetPoint(0, out p);
      DrawRectangle(Pens.Black, p.X-r, p.Y-r, r, r);
    }

    public override void DrawLastPoint(ICurve curve)
    {
      int r = 5;
      IPoint p;
      curve.GetPoint(1, out p);
      DrawRectangle(Pens.Black, p.X-r, p.Y-r, r, r);
    }

    public override void DrawSegment(ICurve curve, double t1, double t2)
    {
      IPoint p1, p2;
      curve.GetPoint(t1, out p1);
      curve.GetPoint(t2, out p2);
      DrawLine(Pens.Black, p1.X + (p2.X - p1.X) * 0.2, p1.Y + (p2.Y - p1.Y) * 0.2, p2.X - (p2.X - p1.X) * 0.2, p2.Y - (p2.Y - p1.Y) * 0.2);
    }
  }
}
