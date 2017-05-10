using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuples;
using MetaCnvInternals;



namespace RecordField0
{
  public class cons
  {
    public __MetaCnvResult<unit> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<unit>();
      __res.Value = default(unit);
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
        default: break;
      }
    }
  }
}

namespace RecordField1
{
  public class cons
  {
    public int __arg0;
    public unit __arg1;
    public __MetaCnvResult<Tuples.Tuple<int, unit>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuples.Tuple<int, unit>>();
      __res.Value = default(Tuples.Tuple<int, unit>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            int x = default(int);
            unit xs = default(unit);
            x = __arg0;
            xs = __arg1;
            __opComma<int, unit> __tmp0 = new __opComma<int, unit>();
            __tmp0.__arg0 = x;
            __tmp0.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default: break;
      }
    }
  }
}

namespace RecordField2
{
  public class cons
  {
    public int __arg0;
    public Tuples.Tuple<int, unit> __arg1;
    public __MetaCnvResult<Tuples.Tuple<int, Tuples.Tuple<int, unit>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuples.Tuple<int, Tuples.Tuple<int, unit>>>();
      __res.Value = default(Tuples.Tuple<int, Tuples.Tuple<int, unit>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            int x = default(int);
            Tuples.Tuple<int, unit> xs = default(Tuples.Tuple<int, unit>);
            x = __arg0;
            xs = __arg1;
            __opComma<int, Tuples.Tuple<int, unit>> __tmp0 = new __opComma<int, Tuples.Tuple<int, unit>>();
            __tmp0.__arg0 = x;
            __tmp0.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default: break;
      }
    }
  }
}

namespace Record
{
  public class physicalBody
  {
    public __MetaCnvResult<Tuples.Tuple<int, Tuples.Tuple<int, unit>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuples.Tuple<int, Tuples.Tuple<int, unit>>>();
      __res.Value = default(Tuples.Tuple<int, Tuples.Tuple<int, unit>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuples.Tuple<int, Tuples.Tuple<int, unit>> res = default(Tuples.Tuple<int, Tuples.Tuple<int, unit>>);
            RecordField2.cons __tmp0 = new RecordField2.cons();
            __tmp0.__arg0 = 1;
            __opComma<int, unit> __tmp1 = new __opComma<int, unit>();
            __tmp1.__arg0 = 5;
            __tmp1.__arg1 = new unit();
            __tmp0.__arg1 = __tmp1;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuples.Tuple<int, Tuples.Tuple<int, unit>>> __tmp2 = __tmp0.__res;
            res = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = res;
            break;
          }
        default:
          break;
      }
    }
  }

  public class TestRecord
  {
    public static void TestRecords(int components)
    {
      Random r = new Random();
      int last = r.Next(-100, 100);
      Tuples.Tuple<int, unit> item1 = new __opComma<int, unit>(last, new unit());
      Tuples.Tuple<int, Tuples.Tuple<int, unit>> item2 = new __opComma<int, Tuples.Tuple<int, unit>>(3, item1);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>> item3 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>(0, item2);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>> item4 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>(-1, item3);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>> item5 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>(-1, item4);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>> item6 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>(0, item5);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>> item7 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>(9, item6);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>> item8 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>(4, item7);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>> item9 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>(3, item8);
      Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>> item10 = new __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>>(5, item9);
      switch (components)
      {
        case 1:
          {
            Getter0.get getTest = new Getter0.get();
            getTest.__arg0 = item1;
            getTest.Run();
            break;
          }
        case 2:
          {
            Getter1.get getTest = new Getter1.get();
            getTest.__arg0 = item2;
            getTest.Run();
            break;
          }
        case 3:
          {
            Getter2.get getTest = new Getter2.get();
            getTest.__arg0 = item3;
            getTest.Run();
            break;
          }
        case 4:
          {
            Getter3.get getTest = new Getter3.get();
            getTest.__arg0 = item4;
            getTest.Run();
            break;
          }
        case 5:
          {
            Getter4.get getTest = new Getter4.get();
            getTest.__arg0 = item5;
            getTest.Run();
            break;
          }
        case 6:
          {
            Getter5.get getTest = new Getter5.get();
            getTest.__arg0 = item6;
            getTest.Run();
            break;
          }
        case 7:
          {
            Getter6.get getTest = new Getter6.get();
            getTest.__arg0 = item7;
            getTest.Run();
            break;
          }
        case 8:
          {
            Getter7.get getTest = new Getter7.get();
            getTest.__arg0 = item8;
            getTest.Run();
            break;
          }
        case 9:
          {
            Getter8.get getTest = new Getter8.get();
            getTest.__arg0 = item9;
            getTest.Run();
            break;
          }
        case 10:
          {
            Getter9.get getTest = new Getter9.get();
            getTest.__arg0 = item10;
            getTest.Run();
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter0
{
  public class get
  {
    public Tuples.Tuple<int, unit> __arg0;
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
            int x = default(int);
            unit xs = default(unit);
            if (!(__arg0 is __opComma<int, unit>))
            {
              goto default;
            }
            __opComma<int, unit> __tmp0 = (__opComma<int, unit>)__arg0;
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

namespace Getter1
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, unit>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, unit> xs = default(Tuples.Tuple<int, unit>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, unit>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, unit>> __tmp0 = (__opComma<int, Tuples.Tuple<int, unit>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter0.get __tmp1 = new Getter0.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter2
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, unit>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, unit>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter1.get __tmp1 = new Getter1.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter3
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter2.get __tmp1 = new Getter2.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter4
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter3.get __tmp1 = new Getter3.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter5
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter4.get __tmp1 = new Getter4.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter6
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter5.get __tmp1 = new Getter5.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter7
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter6.get __tmp1 = new Getter6.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter8
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter7.get __tmp1 = new Getter7.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}

namespace Getter9
{
  public class get
  {
    public Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>> __arg0;
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
            int x = default(int);
            Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>> xs = default(Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>);
            int y = default(int);
            if (!(__arg0 is __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>>))
            {
              goto default;
            }
            __opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>> __tmp0 = (__opComma<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, Tuples.Tuple<int, unit>>>>>>>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;

            Getter8.get __tmp1 = new Getter8.get();
            __tmp1.__arg0 = xs;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<int> __tmp2 = __tmp1.__res;
            y = __tmp2.Value;
            __res.HasValue = true;
            __res.Value = y;
            break;
          }
        default:
          break;
      }
    }
  }
}






