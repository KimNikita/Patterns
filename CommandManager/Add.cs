using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandManager
{
  public class Add : ACommand
  {
    private List<Circle> list;
    private Circle c;
    public Add(List<Circle> _list, Circle _c)
    {
      list = _list;
      c = _c;
    }
    protected override ICommand Clone()
    {
      return new Add(list, c);
    }

    protected override void DoExecute()
    {
      list.Add(c);
    }
  }
}
