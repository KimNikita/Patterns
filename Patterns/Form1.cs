using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual;
using Geometry;

namespace Patterns
{
  public partial class Form1 : Form
  {
    IContext context1, context2;
    IDrawer drawer1, drawer2;
    VisualCurve[] curves = {
      new VisualBezier(new Bezier(new Geometry.Point { X=100, Y=100},
        new Geometry.Point { X=150, Y=150},
        new Geometry.Point { X=200, Y=100},
        new Geometry.Point { X=250, Y=150})),
      new VisualLine(new Line(new Geometry.Point { X=100, Y=300}, new Geometry.Point { X=200, Y=400})),
    };
    public Form1()
    {
      InitializeComponent();

    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      context1 = new BaseGraphicsContext(e.Graphics);
      drawer1 = new CurveDrawerGreenArrow(context1);
      context2 = new SVGContext("svgContext.svg");
      drawer2 = new CurveDrawerBlackSquares(context2);
      foreach (var c in curves)
      {
        c.Draw(drawer1);
        c.Draw(drawer2);
      }
    }
  }
}
