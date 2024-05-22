using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommandManager
{
  public class Reset : ACommand
  {
    private List<Circle> list;
    public Reset(List<Circle> _list)
    {
      list = _list;
    }

    protected override ICommand Clone()
    {
      return new Reset(list);
    }

    protected override void DoExecute()
    {
      list.Clear();
    }
  }
}
