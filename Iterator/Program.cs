using System;
using System.Collections.Generic;

namespace Iterator
{
  interface IIteratorIn<T, R>
  {
    public void Action(T item);
    public void GetResult(out R res);
  }

  class IteratorCounterInt : IIteratorIn<int, int>
  {
    private Dictionary<int, int> a = new Dictionary<int, int>();

    public void Action(int item)
    {
      if (a.ContainsKey(item))
        a[item] += 1;
      else
        a.Add(item, 1);
    }

    public void GetResult(out int res)
    {
      if (a.Count == 0)
      {
        res = -1;
        return;
      }

      int count = 0;
      foreach (var key in a.Keys)
        if (a[key] > 1)
          count += a[key];
      res = count;
      a.Clear();
    }
  }

  interface IIterableIn<T, R>
  {
    public void Iterate(IIteratorIn<T, R> iter);
  }

  class MyCollection : IIterableIn<int, int>
  {
    private int[] a = new int[] { 1, 2, 1, 3, 4, 4, 3, 2, 5, 1, 6, 7 };
    public void Iterate(IIteratorIn<int, int> iter)
    {
      for (int i = 0; i < a.Length; i++)
      {
        iter.Action(a[i]);
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      IIterableIn<int, int> mc = new MyCollection();
      IIteratorIn<int, int> iter = new IteratorCounterInt();
      mc.Iterate(iter);
      int res;
      iter.GetResult(out res);
      System.Console.WriteLine(res);
    }
  }
}
