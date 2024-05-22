using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandManager
{
  public partial class Form1 : Form
  {

    private List<Circle> list = new List<Circle>();
    public Form1()
    {
      InitializeComponent();
      new Reset(list).Execute();
    }

    private void cancel_Click(object sender, EventArgs e)
    {
      CM.Instance.Undo();
      Refresh();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      foreach (var c in list)
      {
        c.Draw(e.Graphics);
      }
    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
      bool inCircle = false;
      foreach (var c in list)
      {
        if (c.IsMyPoint(e.Location))
        {
          new Remove(list, c).Execute();
          inCircle = true;
          break;
        }
      }
      if (!inCircle)
      {
        new Add(list, new Circle(e.Location, 10)).Execute();
      }
      Refresh();
    }
  }
}
