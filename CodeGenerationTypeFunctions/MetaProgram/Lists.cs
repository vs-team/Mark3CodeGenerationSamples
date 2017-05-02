using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaCnvInternals;

namespace Lists
{
  public interface List<a> { }

  public class __opColon__opColon<a> : List<a>
  {
    public string __name = "::";
    public a __arg0;
    public List<a> __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class nil<a> : List<a>
  {
    public string __name = "nil";

    public override string ToString()
    {
      return __name;
    }
  }

  public class length<a>
  {
    public List<a> __arg0;
    public __MetaCnvResult<int> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<int>();
      __res.Value = default(int);
      __res.HasValue = false;
      switch (__ruleIndex)
      {
        case 0:
          {
            if (!(__arg0 is nil<a>))
            {
              goto case 1;
            }

            nil<a> __tmp0 = (nil<a>)__arg0;
            __res.Value = 0;
            __res.HasValue = true;
            break;
          }

        case 1:
          {
            a x = default(a);
            List<a> xs = default(List<a>);
            int y = default(int);

            if (!(__arg0 is __opColon__opColon<a>))
            {
              goto default;
            }

            __opColon__opColon<a> __tmp0 = (__opColon__opColon<a>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            length<a> __tmp2 = new length<a>();
            __tmp2.__arg0 = xs;
            __tmp2.Run();

            if (!__tmp2.__res.HasValue)
            {
              goto default;
            }

            __MetaCnvResult<int> __tmp3 = __tmp2.__res;
            y = __tmp3.Value;
            __res.HasValue = true;
            __res.Value = 1 + y;
            break;
          }

        default: break;

      }

    }    
  }

  public class append<a>
  {
    public List<a> __arg0;
    public List<a> __arg1;
    public __MetaCnvResult<List<a>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<List<a>>();
      __res.Value = default(List<a>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            List<a> ys = default(List<a>);
            if (!(__arg0 is nil<a>))
            {
              goto case 1;
            }
            ys = __arg1;
            __res.HasValue = true;
            __res.Value = ys;
            break;
          }
        case 1:
          {
            a x = default(a);
            List<a> xs = default(List<a>);
            List<a> ys = default(List<a>);
            List<a> zs = default(List<a>);
            if (!(__arg0 is __opColon__opColon<a>))
            {
              goto default;
            }
            __opColon__opColon<a> __tmp0 = (__opColon__opColon <a>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            ys = __arg1;
            append<a> __tmp1 = new append<a>();
            __tmp1.__arg0 = xs;
            __tmp1.__arg1 = ys;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<List<a>> __tmp2 = __tmp1.__res;
            zs = __tmp2.Value;
            __opColon__opColon<a> __tmp3 = new __opColon__opColon<a>();
            __tmp3.__arg0 = x;
            __tmp3.__arg1 = zs;
            __res.HasValue = true;
            __res.Value = __tmp3;
            break;
          }
        default: break;
      }
    }

  }


}
