using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup
{

  public partial class Form1 : Form
  {
    private CList cList = new CList();
    private ICommand backup;
    public Form1()
    {
      InitializeComponent();
      new Reset(cList.GetList()).Execute();
    }

    private void cancel_Click(object sender, EventArgs e)
    {
      CM.Instance.Undo();
      Refresh();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      foreach (var c in cList.GetList())
      {
        c.Draw(e.Graphics);
      }
    }

    private void Form1_MouseClick(object sender, MouseEventArgs e)
    {
      bool inCircle = false;
      foreach (var c in cList.GetList())
      {
        if (c.IsMyPoint(e.Location))
        {
          new Remove(cList.GetList(), c).Execute();
          inCircle = true;
          break;
        }
      }
      if (!inCircle)
      {
        new Add(cList.GetList(), new Circle(e.Location, 10)).Execute();
      }
      Refresh();
    }

    private void save_Click(object sender, EventArgs e)
    {
      backup = new MyBackup(MM.Instance.CreateBackup());
    }

    private void restore_Click(object sender, EventArgs e)
    {
      backup.Execute();
      Refresh();
    }
  }
}
