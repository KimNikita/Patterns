using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
  public sealed class MM : IMementable
  {
    private static MM instance = null;
    private List<IMementable> mem;
    private MM()
    {
      mem = new List<IMementable>();
    }
    public static MM Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new MM();
        }
        return instance;
      }
    }
    public void Registry(IMementable m)
    {
      mem.Add(m);
    }
    public void UnRegistry(IMementable m)
    {
      mem.Remove(m);
    }

    private class MMMemento : IMemento
    {
      private List<IMementable> mem;
      public MMMemento()
      {
        mem = new List<IMementable>();
        foreach (IMementable m in MM.instance.mem)
        {
          mem.Add(m);
        }
      }
      public void Restore()
      {
        MM.instance.mem = mem;
      }
    }

    public IMemento CreateMemento()
    {
      return new MMMemento();
    }

    public List<IMemento> CreateBackup()
    {
      List<IMemento> ml = new List<IMemento>();
      ml.Add(CreateMemento());
      foreach (IMementable m in mem)
      {
        ml.Add(m.CreateMemento());
      }
      return ml;
    }
  }
}