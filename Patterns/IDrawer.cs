using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Visual
{
  public interface IDrawer
  {
    void DrawEllipse(Pen pen, double x, double y, double w, double h);
    void DrawLine(Pen pen, double x1, double x2, double y1, double y2);
    void DrawRectangle(Pen pen, double x, double y, double w, double h);
  }
}
