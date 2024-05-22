using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Visual
{
  class SVGContext : IContext
  {
    private string path;
    private StreamWriter writer;

    public SVGContext(string _path)
    {
      path = _path;
      using (writer = new StreamWriter(path, false)) { }
    }

    public void DrawEllipse(Pen pen, double x, double y, double w, double h)
    {
      using (writer = new StreamWriter(path, true))
      {
        writer.WriteLine(string.Format("<svg><ellipse cx=\"{0}\" cy=\"{1}\" rx=\"{2}\" ry=\"{3}\" stroke = \"{4}\"/></svg>", x.ToString(System.Globalization.CultureInfo.InvariantCulture), y.ToString(System.Globalization.CultureInfo.InvariantCulture), (w / 2).ToString(System.Globalization.CultureInfo.InvariantCulture), (h / 2).ToString(System.Globalization.CultureInfo.InvariantCulture), pen.Color.Name.ToLower()));
      }
    }

    public void DrawLine(Pen pen, double x1, double x2, double y1, double y2)
    {
      using (writer = new StreamWriter(path, true))
      {
        writer.WriteLine(string.Format("<svg><line x1=\"{0}\" y1=\"{1}\" x2=\"{2}\" y2=\"{3}\" stroke = \"{4}\"/></svg>", x1.ToString(System.Globalization.CultureInfo.InvariantCulture), y1.ToString(System.Globalization.CultureInfo.InvariantCulture), x2.ToString(System.Globalization.CultureInfo.InvariantCulture), y2.ToString(System.Globalization.CultureInfo.InvariantCulture), pen.Color.Name.ToLower()));
      }
    }

    public void DrawRectangle(Pen pen, double x, double y, double w, double h)
    {
      using (writer = new StreamWriter(path, true))
      {
        writer.WriteLine(string.Format("<svg><rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\" stroke = \"{4}\"/></svg>", x.ToString(System.Globalization.CultureInfo.InvariantCulture), y.ToString(System.Globalization.CultureInfo.InvariantCulture), w.ToString(System.Globalization.CultureInfo.InvariantCulture), h.ToString(System.Globalization.CultureInfo.InvariantCulture), pen.Color.Name.ToLower()));
      }
    }
  }
}
