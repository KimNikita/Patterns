using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Geometry;

namespace Visual
{
  public abstract class ACurveDrawer : IDrawer
  {
    protected IContext context;
    
    public ACurveDrawer(IContext _context)
    {
      context = _context;
    }

    public abstract void DrawFirstPoint(ICurve curve);
    public abstract void DrawLastPoint(ICurve curve);
    public abstract void DrawSegment(ICurve curve, double t1, double t2);

    public void DrawLine(Pen pen, double x1, double x2, double y1, double y2)
    {
      context.DrawLine(pen, x1, x2, y1, y2);
    }

    public void DrawEllipse(Pen pen, double x, double y, double w, double h)
    {
      context.DrawEllipse(pen, x, y, w, h);
    }

    public void DrawRectangle(Pen pen, double x, double y, double w, double h)
    {
      context.DrawRectangle(pen, x, y, w, h);
    }
  }
}
