using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandManager
{
  public sealed class CM
  {
    private static CM instance = null;
    private bool flag = false;
    private List<ICommand> comm;
    private CM()
    {
      comm = new List<ICommand>();
    }
    public static CM Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new CM();
        }
        return instance;
      }
    }
    public void Registry(ICommand cm)
    {
      if (!flag)
      {
        if (comm.Count == 0)
        {
          if (cm is Reset)
          {
            comm.Add(cm);
          }
        }
        else
        {
          comm.Add(cm);
        }
      }
    }
    public void Undo()
    {
      if (comm.Count > 1)
      {
        flag = true;
        comm.RemoveAt(comm.Count - 1);
        foreach (var cm in comm)
        {
          cm.Execute();
        }
        flag = false;
      }
    }
  }


}
