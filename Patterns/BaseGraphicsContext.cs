using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual
{
  public class BaseGraphicsContext : IContext
  {
    private Graphics graphics;

    public BaseGraphicsContext(Graphics _graphics)
    {
      graphics = _graphics;
    }
    public void DrawEllipse(Pen pen, double x, double y, double w, double h)
    {
      graphics.DrawEllipse(pen, (float)x, (float)y, (float)w, (float)h);
    }

    public void DrawLine(Pen pen, double x1, double x2, double y1, double y2)
    {
      graphics.DrawLine(pen, (float)x1, (float)x2, (float)y1, (float)y2);
    }

    public void DrawRectangle(Pen pen, double x, double y, double w, double h)
    {
      graphics.DrawRectangle(pen, (float)x, (float)y, (float)w, (float)h);
    }
  }
}
