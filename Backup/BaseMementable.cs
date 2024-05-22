using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
  public abstract class BaseMementable : IMementable
  {
    public abstract IMemento CreateMemento();
    public BaseMementable()
    {
      MM.Instance.Registry(this);
    }
    ~BaseMementable()
    {
      MM.Instance.UnRegistry(this);
    }
  }
}
