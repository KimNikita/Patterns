using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Visual
{
  public class CurveDrawerGreenArrow : ACurveDrawer
  {
    public CurveDrawerGreenArrow(IContext _context) : base(_context) { }
    public override void DrawFirstPoint(ICurve curve)
    {
      int r = 6;
      IPoint p;
      curve.GetPoint(0, out p);
      DrawEllipse(Pens.Green, p.X - r, p.Y - r, 2 * r, 2 * r);
    }

    public override void DrawLastPoint(ICurve curve)
    {
      double degree;
      IPoint p1, p2;
      curve.GetPoint(1, out p2);
      curve.GetPoint(0.9, out p1);
      if (p2.X > p1.X && p2.Y <= p1.Y)
        degree = Math.Atan((p1.Y - p2.Y) / (p2.X - p1.X));
      else if (p2.X > p1.X && p2.Y > p1.Y)
        degree = Math.Atan((p1.Y - p2.Y) / (p2.X - p1.X)) + 2 * Math.PI;
      else if (p2.X < p1.X)
        degree = Math.Atan((p1.Y - p2.Y) / (p2.X - p1.X)) + Math.PI;
      else
      {
        if (p2.Y < p1.Y)
          degree = Math.PI / 2;
        else if (p2.Y > p1.Y)
          degree = Math.PI * 3 / 2;
        else
          degree = 0;
      }
      double x3 = p2.X - Math.Round(20 * Math.Cos(degree + Math.PI / 10));
      double y3 = p2.Y + Math.Round(20 * Math.Sin(degree + Math.PI / 10));
      double x4 = p2.X - Math.Round(20 * Math.Cos(degree - Math.PI / 10));
      double y4 = p2.Y + Math.Round(20 * Math.Sin(degree - Math.PI / 10));
      DrawLine(Pens.Green, p2.X, p2.Y, x3, y3);
      DrawLine(Pens.Green, p2.X, p2.Y, x4, y4);
    }

    public override void DrawSegment(ICurve curve, double t1, double t2)
    {
      IPoint p1, p2;
      curve.GetPoint(t1, out p1);
      curve.GetPoint(t2, out p2);
      DrawLine(Pens.Green, p1.X, p1.Y, p2.X, p2.Y);
    }
  }
}
