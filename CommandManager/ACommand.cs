using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CommandManager
{
  public abstract class ACommand : ICommand
  {
    public void Execute()
    {
      CM.Instance.Registry(this.Clone());
      DoExecute();
    }

    protected abstract ICommand Clone();

    protected abstract void DoExecute();
  }
}
