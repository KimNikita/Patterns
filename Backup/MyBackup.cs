using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
  public class MyBackup : ACommand, IMemento
  {
    private List<IMemento> mementos;
    public MyBackup(List<IMemento> m)
    {
      mementos = new List<IMemento>();
      foreach(IMemento im in m)
      {
        mementos.Add(im);
      }
    }

    public void Restore()
    {
      foreach (IMemento m in mementos)
      {
        m.Restore();
      }
    }

    protected override ICommand Clone()
    {
      return new MyBackup(mementos);
    }

    protected override void DoExecute()
    {
      this.Restore();
    }
  }
}
