using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaCnvInternals;
using Lists;
using Tuples;
using System.Collections.Immutable;

namespace Basics
{
  public interface Expr { }
  public interface Value : Expr { }
  public interface ID : Expr { }
  public interface ctxt { }

  public class __opDollari : Value
  {
    public string __name = "$f";
    public int __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollars : Value
  {
    public string __name = "$s";
    public string __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollarb : Value
  {
    public string __name = "$b";
    public bool __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollarf : Value
  {
    public string __name = "$f";
    public float __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollarVector2 : Value
  {
    public string __name = "$Vector2";
    public float __arg0;
    public float __arg1;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + ")";
    }
  }

  public class __opDollarl : Value
  {
    public string __name = "$l";
    public Lists.List<Value> __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollart : Value
  {
    public string __name = "$t";
    public Tuples.Tuple<Value, Value> __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class Tuple : Value
  {
    public string __name = "$t";
    public Tuples.Tuple<Value, Value> __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollarfirst : Expr
  {
    public string __name = "$first";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollarsecond : Expr
  {
    public string __name = "$second";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opDollar : ID
  {
    public string __name = "$";
    public string __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class __opPlus : Expr
  {
    public string __name = "+";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opMinus : Expr
  {
    public string __name = "-";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opMul : Expr
  {
    public string __name = "*";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opDiv : Expr
  {
    public string __name = "/";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opBar__opBar : Expr
  {
    public string __name = "||";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opAnd__opAnd : Expr
  {
    public string __name = "||";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opPlus__opPlus : Expr
  {
    public string __name = "++";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class __opAt : Expr
  {
    public string __name = "@";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class lt : Expr
  {
    public string __name = "lt";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class leq : Expr
  {
    public string __name = "leq";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class gt : Expr
  {
    public string __name = "gt";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class geq : Expr
  {
    public string __name = "geq";
    public Expr __arg0;
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }

  public class Context : ctxt
  {
    public string __name = "Context";
    public ImmutableDictionary<string, Value> __arg0;
    public ImmutableDictionary<string, Value> __arg1;
    public ImmutableDictionary<string, Value> __arg2;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + " " + __arg2 + ")";
    }
  }

  public class eval
  {
    public Expr __arg0;
    public ctxt __arg1;
    public __MetaCnvResult<Value> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Value>();
      __res.Value = default(Value);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            string a = default(string);
            ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> entity = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> world = default(ImmutableDictionary<string, Value>);
            Value res = default(Value);
            if (!(__arg0 is __opDollar))
            {
              goto case 1;
            }
            if (!(__arg1 is Context))
            {
              goto case 1;
            }
            __opDollar __tmp0 = (__opDollar)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            locals = __tmp1.__arg0;
            entity = __tmp1.__arg1;
            world = __tmp1.__arg2;

            if (!(locals.ContainsKey(a)))
            {
              goto case 1;
            }

            res = locals[a];
            __res.HasValue = true;
            __res.Value = res;
            break;
          }
        case 1:
          {
            string a = default(string);
            ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> entity = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> world = default(ImmutableDictionary<string, Value>);
            Value r = default(Value);
            Value res = default(Value);
            if (!(__arg0 is __opDollar))
            {
              goto case 2;
            }
            if (!(__arg1 is Context))
            {
              goto case 2;
            }
            __opDollar __tmp0 = (__opDollar)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            locals = __tmp1.__arg0;
            entity = __tmp1.__arg1;
            world = __tmp1.__arg2;
            r = entity[a];
            eval __tmp2 = new eval();
            __tmp2.__arg0 = r;
            Context __tmp3 = new Context();
            __tmp3.__arg0 = locals;
            __tmp3.__arg1 = entity;
            __tmp3.__arg2 = world;
            __tmp2.__arg1 = __tmp3;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto case 2;
            }
            __MetaCnvResult<Value> __tmp4 = __tmp2.__res;
            res = __tmp4.Value;
            __res.HasValue = true;
            __res.Value = res;
            break;
          }
        case 2:
          {
            string a = default(string);
            ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> entity = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> world = default(ImmutableDictionary<string, Value>);
            Value res = default(Value);
            if (!(__arg0 is __opDollar))
            {
              goto case 3;
            }
            if (!(__arg1 is Context))
            {
              goto case 3;
            }
            __opDollar __tmp0 = (__opDollar)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            locals = __tmp1.__arg0;
            entity = __tmp1.__arg1;
            world = __tmp1.__arg2;

            res = world[a];
            __res.HasValue = true;
            __res.Value = res;
            break;
          }
        case 3:
          {
            bool a = default(bool);
            ctxt m = default(ctxt);
            if (!(__arg0 is __opDollarb))
            {
              goto case 4;
            }
            if (!(__arg1 is Context))
            {
              goto case 4;
            }
            __opDollarb __tmp0 = (__opDollarb)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            m = __tmp1;
            __opDollarb __tmp2 = new __opDollarb();
            __tmp2.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 4:
          {
            int a = default(int);
            ctxt m = default(ctxt);
            if (!(__arg0 is __opDollari))
            {
              goto case 5;
            }
            if (!(__arg1 is Context))
            {
              goto case 5;
            }
            __opDollari __tmp0 = (__opDollari)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            m = __tmp1;
            __opDollari __tmp2 = new __opDollari();
            __tmp2.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 5:
          {
            string a = default(string);
            ctxt m = default(ctxt);
            if (!(__arg0 is __opDollars))
            {
              goto case 6;
            }
            if (!(__arg1 is Context))
            {
              goto case 6;
            }
            __opDollars __tmp0 = (__opDollars)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            m = __tmp1;
            __opDollars __tmp2 = new __opDollars();
            __tmp2.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 6:
          {
            float a = default(float);
            ctxt m = default(ctxt);
            if (!(__arg0 is __opDollarf))
            {
              goto case 7;
            }
            if (!(__arg1 is Context))
            {
              goto case 7;
            }
            __opDollarf __tmp0 = (__opDollarf)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            m = __tmp1;
            __opDollarf __tmp2 = new __opDollarf();
            __tmp2.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 7:
          {
            Tuples.Tuple<Value, Value> a = default(Tuples.Tuple<Value, Value>);
            Context m = default(Context);
            if (!(__arg0 is __opDollart))
            {
              goto case 8;
            }
            if (!(__arg1 is Context))
            {
              goto case 8;
            }
            __opDollart __tmp0 = (__opDollart)__arg0;
            a = __tmp0.__arg0;
            Context __tmp1 = (Context)__arg1;
            m = __tmp1;
            __opDollart __tmp2 = new __opDollart();
            __tmp2.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 8:
          {
            float x = default(float);
            float y = default(float);
            Context m = default(Context);
            if (!(__arg0 is __opDollarVector2))
            {
              goto case 9;
            }
            if (!(__arg1 is Context))
            {
              goto case 8;
            }
            __opDollarVector2 __tmp0 = (__opDollarVector2)__arg0;
            x = __tmp0.__arg0;
            y = __tmp0.__arg1;
            Context __tmp1 = (Context)__arg1;
            m = __tmp1;
            __opDollarVector2 __tmp2 = new __opDollarVector2();
            __tmp2.__arg0 = x;
            __tmp2.__arg1 = y;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 9:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float x1 = default(float);
            float x2 = default(float);
            float y1 = default(float);
            float y2 = default(float);
            float resx = default(float);
            float resy = default(float);
            if (!(__arg0 is __opPlus))
            {
              goto case 10;
            }
            __opPlus __tmp0 = (__opPlus)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 10;
            }
            if (!(__tmp1.__res.Value is __opDollarVector2))
            {
              goto case 10;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarVector2 __tmp3 = (__opDollarVector2)__tmp2.Value;
            x1 = __tmp3.__arg0;
            y1 = __tmp3.__arg1;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 10;
            }
            if (!(__tmp4.__res.Value is __opDollarVector2))
            {
              goto case 10;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarVector2 __tmp6 = (__opDollarVector2)__tmp5.Value;
            x2 = __tmp6.__arg0;
            y2 = __tmp6.__arg1;
            resx = x1 + x2;
            resy = y1 + y2;

            __opDollarVector2 __tmp7 = new __opDollarVector2();
            __tmp7.__arg0 = resx;
            __tmp7.__arg1 = resy;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 10:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float x1 = default(float);
            float x2 = default(float);
            float y1 = default(float);
            float y2 = default(float);
            float resx = default(float);
            float resy = default(float);
            if (!(__arg0 is __opMinus))
            {
              goto case 11;
            }
            __opMinus __tmp0 = (__opMinus)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 11;
            }
            if (!(__tmp1.__res.Value is __opDollarVector2))
            {
              goto case 11;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarVector2 __tmp3 = (__opDollarVector2)__tmp2.Value;
            x1 = __tmp3.__arg0;
            y1 = __tmp3.__arg1;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 11;
            }
            if (!(__tmp4.__res.Value is __opDollarVector2))
            {
              goto case 11;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarVector2 __tmp6 = (__opDollarVector2)__tmp5.Value;
            x2 = __tmp6.__arg0;
            y2 = __tmp6.__arg1;
            resx = x1 - x2;
            resy = y1 - y2;

            __opDollarVector2 __tmp7 = new __opDollarVector2();
            __tmp7.__arg0 = resx;
            __tmp7.__arg1 = resy;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 11:
          {
            Expr v = default(Expr);
            Expr s = default(Expr);
            ctxt m = default(ctxt);
            float x1 = default(float);
            float y1 = default(float);
            float s1 = default(float);
            float resx = default(float);
            float resy = default(float);
            if (!(__arg0 is __opMul))
            {
              goto case 12;
            }
            __opMul __tmp0 = (__opMul)__arg0;
            v = __tmp0.__arg0;
            s = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 12;
            }
            if (!(__tmp1.__res.Value is __opDollarVector2))
            {
              goto case 12;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarVector2 __tmp3 = (__opDollarVector2)__tmp2.Value;
            x1 = __tmp3.__arg0;
            y1 = __tmp3.__arg1;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = v;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 12;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 12;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            s1 = __tmp6.__arg0;
            resx = x1 * s1;
            resy = y1 * s1;

            __opDollarVector2 __tmp7 = new __opDollarVector2();
            __tmp7.__arg0 = resx;
            __tmp7.__arg1 = resy;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 12:
          {
            Expr v = default(Expr);
            Expr s = default(Expr);
            ctxt m = default(ctxt);
            float x1 = default(float);
            float y1 = default(float);
            float s1 = default(float);
            float resx = default(float);
            float resy = default(float);
            if (!(__arg0 is __opMul))
            {
              goto case 13;
            }
            __opMul __tmp0 = (__opMul)__arg0;
            v = __tmp0.__arg0;
            s = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 13;
            }
            if (!(__tmp1.__res.Value is __opDollarVector2))
            {
              goto case 13;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarVector2 __tmp3 = (__opDollarVector2)__tmp2.Value;
            x1 = __tmp3.__arg0;
            y1 = __tmp3.__arg1;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = v;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 13;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 13;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            s1 = __tmp6.__arg0;
            resx = x1 / s1;
            resy = y1 / s1;

            __opDollarVector2 __tmp7 = new __opDollarVector2();
            __tmp7.__arg0 = resx;
            __tmp7.__arg1 = resy;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 13:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);
            int res = default(int);

            if (!(__arg0 is __opPlus))
            {
              goto case 14;
            }
            __opPlus __tmp0 = (__opPlus)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg0;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 14;
            }
            if(!(__tmp1.__res.Value is __opDollari))
            {
              goto case 14;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            break;
          }
        case 14:
          {
            break;
          }
        default: break;
      }
    }
  }
}
