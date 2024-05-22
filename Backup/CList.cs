using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
  public class CList : BaseMementable
  {
    private List<Circle> list;

    public CList()
    {
      list = new List<Circle>();
    }
    public List<Circle> GetList()
    {
      return list;
    }
    private class CListMemento : IMemento
    {
      private CList owner;
      private List<Circle> list;
      public CListMemento(CList c)
      {
        owner = c;
        list = new List<Circle>();
        foreach (Circle ci in c.list)
        {
          list.Add(ci);
        }
      }
      public void Restore()
      {
        owner.list.Clear();
        foreach (Circle c in list)
        {
          owner.list.Add(c);
        }
      }
    }
    public override IMemento CreateMemento()
    {
      return new CListMemento(this);
    }
  }
}
