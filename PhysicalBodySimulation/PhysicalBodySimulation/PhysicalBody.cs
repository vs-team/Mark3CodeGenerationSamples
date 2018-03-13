using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EmptyRecord
namespace Record0
{
  using Internals;
  using Tuple;
  using List;

  public class cons
  {
    public __MetaCnvResult<Unit> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Unit>();
      __res.Value = default(Unit);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            unit __tmp0 = new unit();
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default:
          break;
      }
    }
  }
}

//RecordField "Acceleration" Tuple[float,float] EmptyRecord
namespace Record1
{
  using Internals;
  using Tuple;
  using List;

  public class cons
  {
    public Tuple<float, float> __arg0;
    public Unit __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Unit>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Unit>>();
      __res.Value = default(Tuple<Tuple<float, float>, Unit>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = __arg0;
            Unit xs = __arg1;
            __opComma<Tuple<float, float>, Unit> __tmp0 = new __opComma<Tuple<float, float>, Unit>();
            __tmp0.__arg0 = x;
            __tmp0.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default:
          break;
      }
    }
  }
}

//RecordField "Velocity" Tuple[float,float] acceleration
namespace Record2
{
  using Internals;
  using Tuple;
  using List;

  public class cons
  {
    public Tuple<float, float> __arg0;
    public Tuple<Tuple<float,float>, Unit> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = __arg0;
            Tuple<Tuple<float, float>, Unit> xs = __arg1;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp0 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>();
            __tmp0.__arg0 = x;
            __tmp0.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default:
          break;
      }
    }
  }
}

//RecordField "Position" Tuple[float,float] velocity
namespace Record3
{
  using Internals;
  using Tuple;
  using List;

  public class cons
  {
    public Tuple<float, float> __arg0;
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = __arg0;
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = __arg1;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
            __tmp0.__arg0 = x;
            __tmp0.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default:
          break;
      }
    }
  }
}

//GetField PhysicalBodyType "Position"
namespace GetField0
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            __res.HasValue = true;
            __res.Value = x;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace GetField1
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __arg0;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Unit> xs = default(Tuple<Tuple<float, float>, Unit>);
            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            __res.HasValue = true;
            __res.Value = x;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace GetField2
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<Tuple<float, float>, Unit> __arg0;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Unit xs = default(Unit);
            if (!(__arg0 is __opComma<Tuple<float, float>, Unit>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Unit> __tmp0 = (__opComma<Tuple<float, float>, Unit>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            __res.HasValue = true;
            __res.Value = x;
            break;
          }
        default:
          break;
      }
    }
  }
}

//GetField PhysicalBodyType "Velocity"
namespace GetField3
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
            Tuple<float, float> v = default(Tuple<float, float>);
            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            GetField1.get __tmp1 = new GetField1.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            v = __tmp1.__res.Value;
            __res.HasValue = true;
            __res.Value = v;
            break;
          }
        default:
          break;
      }
    }
  }

}

namespace GetField4
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __arg0;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Unit> xs = default(Tuple<Tuple<float, float>, Unit>);
            Tuple<float, float> v = default(Tuple<float, float>);
            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            GetField2.get __tmp1 = new GetField2.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp2 = __tmp1.__res;
            v = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = v;
            break;
          }
        default:
          break;
      }
    }
  }
}

//GetField PhysicalBodyType "Acceleration"
namespace GetField5
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
            Tuple<float, float> v = default(Tuple<float, float>);
            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            GetField4.get __tmp1 = new GetField4.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            v = __tmp1.__res.Value;
            __res.HasValue = true;
            __res.Value = v;
            break;
          }
        default:
          break;
      }
    }
  }
}

//SetField "Position" PhysicalBodyType
namespace SetField0
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public Tuple<float, float> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
            Tuple<float, float> v = default(Tuple<float, float>);
            
            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp1 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace SetField1
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __arg0;
    public Tuple<float, float> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Unit> xs = default(Tuple<Tuple<float, float>, Unit>);
            Tuple<float, float> v = default(Tuple<float, float>);

            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp1 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        default:
          break;
      }
    }
  }
}

//SetField "Velocity" PhysicalBodyType
namespace SetField2
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public Tuple<float, float> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
            Tuple<float, float> v = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);

            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            SetField1.set __tmp1 = new SetField1.set();
            __tmp1.__arg0 = xs;
            __tmp1.__arg1 = v;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp2 = __tmp1.__res;
            xs1 = __tmp2.Value;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp3 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
            __tmp3.__arg0 = x;
            __tmp3.__arg1 = xs1;
            __res.HasValue = true;
            __res.Value = __tmp3;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace SetField3
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<Tuple<float, float>, Unit> __arg0;
    public Tuple<float, float> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Unit>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Unit>>();
      __res.Value = default(Tuple<Tuple<float, float>, Unit>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Unit xs = default(Unit);
            Tuple<float, float> v = default(Tuple<float, float>);

            if (!(__arg0 is __opComma<Tuple<float, float>, Unit>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Unit> __tmp0 = (__opComma<Tuple<float, float>, Unit>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            __opComma<Tuple<float, float>, Unit> __tmp1 = new __opComma<Tuple<float, float>, Unit>();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace SetField4
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __arg0;
    public Tuple<float, float> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __res;
    

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Unit> xs = default(Tuple<Tuple<float, float>, Unit>);
            Tuple<float, float> v = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Unit> xs1 = default(Tuple<Tuple<float, float>, Unit>);

            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            SetField3.set __tmp1 = new SetField3.set();
            __tmp1.__arg0 = xs;
            __tmp1.__arg1 = v;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Unit>> __tmp2 = __tmp1.__res;
            xs1 = __tmp2.Value;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> __tmp3 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>();
            __tmp3.__arg0 = x;
            __tmp3.__arg1 = xs1;
            __res.HasValue = true;
            __res.Value = __tmp3;
            break;
          }
        default:
          break;
      }
    }
  }
}

//SetField "Acceleration" PhysicalBodyType
namespace SetField5
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public Tuple<float, float> __arg1;
    public __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
      __res.Value = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<float, float> x = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);
            Tuple<float, float> v = default(Tuple<float, float>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> xs1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>);

            if (!(__arg0 is __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>))
            {
              goto default;
            }
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp0 = (__opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            SetField4.set __tmp1 = new SetField4.set();
            __tmp1.__arg0 = xs;
            __tmp1.__arg1 = v;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp2 = __tmp1.__res;
            xs1 = __tmp2.Value;
            __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp3 = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
            __tmp3.__arg0 = x;
            __tmp3.__arg1 = xs1;
            __res.HasValue = true;
            __res.Value = __tmp3;
            break;
          }
        default:
          break;
      }
    }
  }
}


