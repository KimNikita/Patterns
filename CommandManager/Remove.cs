using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandManager
{
  public class Remove : ACommand
  {
    private List<Circle> list;
    private Circle c;
    public Remove(List<Circle> _list, Circle _c)
    {
      list = _list;
      c = _c;
    }

    protected override ICommand Clone()
    {
      return new Remove(list, c);
    }

    protected override void DoExecute()
    {
      list.Remove(c);
    }
  }
}
