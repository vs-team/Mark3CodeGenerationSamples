using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetaCnvInternals;

namespace Tuples
{
  public interface Tuple<a, b> { }

  public class __opComma<a, b> : Tuple<a, b>
  {
    public string __name = ",";
    public a __arg0;
    public b __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class fst<a, b>
  {
    public Tuple<a, b> __arg0;
    public __MetaCnvResult<a> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<a>();
      __res.Value = default(a);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            a x = default(a);
            b y = default(b);

            if (!(__arg0 is __opComma<a, b>))
            {
              goto default;
            }

            __opComma<a, b> __tmp0 = (__opComma<a, b>)__arg0;
            x = __tmp0.__arg0;
            y = __tmp0.__arg1;
            __res.HasValue = true;
            __res.Value = x;
            break;
          }
        default: break;
      }
    }
  }

  public class snd<a, b>
  {
    public Tuple<a, b> __arg0;
    public __MetaCnvResult<b> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<b>();
      __res.Value = default(b);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            a x = default(a);
            b y = default(b);
            if (!(__arg0 is __opComma<a, b>))
            {
              goto default;
            }
            __opComma<a, b> __tmp0 = (__opComma<a, b>)__arg0;
            x = __tmp0.__arg0;
            y = __tmp0.__arg1;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default: break;
      }
    }
  }
}
