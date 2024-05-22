using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Backup
{
  public class Circle : BaseMementable
  {
    private Point center;
    private int radius;

    public Circle(Point p, int r)
    {
      center = p;
      radius = r;
    }

    private class CircleMemento : IMemento
    {
      private Circle owner;
      private Point center;
      private int radius;
      public CircleMemento(Circle c)
      {
        owner = c;
        center = c.center;
        radius = c.radius;
      }
      public void Restore()
      {
        owner.center = center;
        owner.radius = radius;
      }
    }

    public override IMemento CreateMemento()
    {
      return new CircleMemento(this);
    }

    public void Draw(Graphics g)
    {
      g.DrawEllipse(Pens.Red, center.X - radius, center.Y - radius, radius * 2, radius * 2);
    }

    public bool IsMyPoint(Point p)
    {
      double dist = Math.Sqrt((p.X - center.X) * (p.X - center.X) + (p.Y - center.Y) * (p.Y - center.Y));
      return dist <= radius;
    }
  }
}
