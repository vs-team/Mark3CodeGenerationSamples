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
    public string __name = "$i";
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

  public class __opDollarVector2 : Value, Tuples.Tuple<float, float>
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
    public string __name = "&&";
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
    public Expr __arg1;

    public override string ToString()
    {
      return "(" + " " + __arg0 + " " + __name + " " + __arg1 + ")";
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

  public class vectorx : Expr
  {
    public string __name = "vectorx";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class vectory : Expr
  {
    public string __name = "vectorx";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
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
            __opDollarb __tmp0 = (__opDollarb)__arg0;
            a = __tmp0.__arg0;
            m = __arg1;
            __opDollarb __tmp1 = new __opDollarb();
            __tmp1.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp1;
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
            __opDollari __tmp0 = (__opDollari)__arg0;
            a = __tmp0.__arg0;
            m = __arg1;
            __opDollari __tmp1 = new __opDollari();
            __tmp1.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp1;
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
            __opDollars __tmp0 = (__opDollars)__arg0;
            a = __tmp0.__arg0;
            m = __arg1;
            __opDollars __tmp1 = new __opDollars();
            __tmp1.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp1;
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
            __opDollarf __tmp0 = (__opDollarf)__arg0;
            a = __tmp0.__arg0;
            m = __arg1;
            __opDollarf __tmp1 = new __opDollarf();
            __tmp1.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        case 7:
          {
            Tuples.Tuple<Value, Value> a = default(Tuples.Tuple<Value, Value>);
            ctxt m = default(ctxt);
            if (!(__arg0 is __opDollart))
            {
              goto case 8;
            }
            __opDollart __tmp0 = (__opDollart)__arg0;
            a = __tmp0.__arg0;
            m = __arg1;
            __opDollart __tmp1 = new __opDollart();
            __tmp1.__arg0 = a;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        case 8:
          {
            float x = default(float);
            float y = default(float);
            ctxt m = default(ctxt);
            if (!(__arg0 is __opDollarVector2))
            {
              goto case 9;
            }
            __opDollarVector2 __tmp0 = (__opDollarVector2)__arg0;
            x = __tmp0.__arg0;
            y = __tmp0.__arg1;
            m = __arg1;
            __opDollarVector2 __tmp1 = new __opDollarVector2();
            __tmp1.__arg0 = x;
            __tmp1.__arg1 = y;
            __res.HasValue = true;
            __res.Value = __tmp1;
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
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 14;
            }
            if (!(__tmp1.__res.Value is __opDollari))
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
            if (!(__tmp4.__res.HasValue))
            {
              goto case 14;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 14;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c + d;
            __opDollari __tmp7 = new __opDollari();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 14:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);
            int res = default(int);

            if (!(__arg0 is __opMinus))
            {
              goto case 15;
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
              goto case 15;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 15;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 15;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 15;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c - d;
            __opDollari __tmp7 = new __opDollari();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 15:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);
            int res = default(int);

            if (!(__arg0 is __opMul))
            {
              goto case 16;
            }
            __opMul __tmp0 = (__opMul)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 16;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 16;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 16;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 16;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c * d;
            __opDollari __tmp7 = new __opDollari();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 16:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);
            int res = default(int);

            if (!(__arg0 is __opDiv))
            {
              goto case 17;
            }
            __opDiv __tmp0 = (__opDiv)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 17;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 17;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 17;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 17;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c / d;
            __opDollari __tmp7 = new __opDollari();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 17:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);
            float res = default(float);

            if (!(__arg0 is __opPlus))
            {
              goto case 18;
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
              goto case 18;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 18;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 18;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 18;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c + d;
            __opDollarf __tmp7 = new __opDollarf();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 18:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);
            float res = default(float);

            if (!(__arg0 is __opMinus))
            {
              goto case 19;
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
              goto case 19;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 19;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 19;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 19;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c - d;
            __opDollarf __tmp7 = new __opDollarf();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 19:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);
            float res = default(float);

            if (!(__arg0 is __opMul))
            {
              goto case 20;
            }
            __opMul __tmp0 = (__opMul)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 20;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 20;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 20;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 20;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c * d;
            __opDollarf __tmp7 = new __opDollarf();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 20:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);
            float res = default(float);

            if (!(__arg0 is __opDiv))
            {
              goto case 21;
            }
            __opDiv __tmp0 = (__opDiv)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 21;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 21;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 21;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 21;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            res = c / d;
            __opDollarf __tmp7 = new __opDollarf();
            __tmp7.__arg0 = res;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 21:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            bool c = default(bool);

            if (!(__arg0 is __opBar__opBar))
            {
              goto case 22;
            }
            __opBar__opBar __tmp0 = (__opBar__opBar)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 22;
            }
            if (!(__tmp1.__res.Value is __opDollarb))
            {
              goto case 22;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarb __tmp3 = (__opDollarb)__tmp2.Value;
            c = __tmp3.__arg0;

            if (!(c == true))
            {
              goto case 22;
            }

            __opDollarb __tmp4 = new __opDollarb();
            __tmp4.__arg0 = c;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        case 22:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            bool c = default(bool);
            bool d = default(bool);

            if (!(__arg0 is __opBar__opBar))
            {
              goto case 23;
            }
            __opBar__opBar __tmp0 = (__opBar__opBar)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 23;
            }
            if (!(__tmp1.__res.Value is __opDollarb))
            {
              goto case 23;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarb __tmp3 = (__opDollarb)__tmp2.Value;
            c = __tmp3.__arg0;

            if (c == false)
            {
              goto case 23;
            }

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 23;
            }
            if (!(__tmp4.__res.Value is __opDollarb))
            {
              goto case 23;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarb __tmp6 = (__opDollarb)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 23:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            bool c = default(bool);

            if (!(__arg0 is __opAnd__opAnd))
            {
              goto case 24;
            }
            __opAnd__opAnd __tmp0 = (__opAnd__opAnd)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 24;
            }
            if (!(__tmp1.__res.Value is __opDollarb))
            {
              goto case 24;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarb __tmp3 = (__opDollarb)__tmp2.Value;
            c = __tmp3.__arg0;

            if (!(c == false))
            {
              goto case 24;
            }

            __opDollarb __tmp4 = new __opDollarb();
            __tmp4.__arg0 = c;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        case 24:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            bool c = default(bool);
            bool d = default(bool);

            if (!(__arg0 is __opAnd__opAnd))
            {
              goto case 25;
            }
            __opAnd__opAnd __tmp0 = (__opAnd__opAnd)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 25;
            }
            if (!(__tmp1.__res.Value is __opDollarb))
            {
              goto case 25;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarb __tmp3 = (__opDollarb)__tmp2.Value;
            c = __tmp3.__arg0;

            if (c == true)
            {
              goto case 25;
            }

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 25;
            }
            if (!(__tmp4.__res.Value is __opDollarb))
            {
              goto case 25;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarb __tmp6 = (__opDollarb)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 25:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);

            if (!(__arg0 is lt))
            {
              goto case 26;
            }
            lt __tmp0 = (lt)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 26;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 26;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 26;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 26;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c < d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 26:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);

            if (!(__arg0 is leq))
            {
              goto case 27;
            }
            leq __tmp0 = (leq)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 27;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 27;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 27;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 27;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c <= d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 27:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);

            if (!(__arg0 is gt))
            {
              goto case 28;
            }
            gt __tmp0 = (gt)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 28;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 28;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 28;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 28;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c > d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 28:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            int c = default(int);
            int d = default(int);

            if (!(__arg0 is geq))
            {
              goto case 29;
            }
            geq __tmp0 = (geq)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 29;
            }
            if (!(__tmp1.__res.Value is __opDollari))
            {
              goto case 29;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollari __tmp3 = (__opDollari)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 29;
            }
            if (!(__tmp4.__res.Value is __opDollari))
            {
              goto case 29;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollari __tmp6 = (__opDollari)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c >= d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 29:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);

            if (!(__arg0 is lt))
            {
              goto case 30;
            }
            lt __tmp0 = (lt)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 30;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 30;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 30;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 30;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c < d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 30:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);

            if (!(__arg0 is leq))
            {
              goto case 31;
            }
            leq __tmp0 = (leq)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 31;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 31;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 31;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 31;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c <= d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 31:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);

            if (!(__arg0 is gt))
            {
              goto case 32;
            }
            gt __tmp0 = (gt)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 32;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 32;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 32;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 32;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c > d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 32:
          {
            Expr a = default(Expr);
            Expr b = default(Expr);
            ctxt m = default(ctxt);
            float c = default(float);
            float d = default(float);

            if (!(__arg0 is geq))
            {
              goto case 33;
            }
            geq __tmp0 = (geq)__arg0;
            a = __tmp0.__arg0;
            b = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = a;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 33;
            }
            if (!(__tmp1.__res.Value is __opDollarf))
            {
              goto case 33;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            c = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = b;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 33;
            }
            if (!(__tmp4.__res.Value is __opDollarf))
            {
              goto case 33;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarf __tmp6 = (__opDollarf)__tmp5.Value;
            d = __tmp6.__arg0;

            __opDollarb __tmp7 = new __opDollarb();
            __tmp7.__arg0 = c >= d;
            __res.HasValue = true;
            __res.Value = __tmp7;
            break;
          }
        case 33:
          {
            Lists.List<Value> li = default(Lists.List<Value>);
            ctxt m = default(ctxt);

            if (!(__arg0 is __opDollarl))
            {
              goto case 34;
            }

            __opDollarl __tmp0 = (__opDollarl)__arg0;
            li = __tmp0.__arg0;
            m = __arg1;

            __opDollarl __tmp1 = new __opDollarl();
            __tmp1.__arg0 = li;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        case 34:
          {

            Expr e = default(Expr);
            Expr el = default(Expr);
            ctxt m = default(ctxt);
            Value v = default(Value);
            Lists.List<Value> li = default(Lists.List<Value>);

            if (!(__arg0 is __opPlus__opPlus))
            {
              goto case 35;
            }
            __opPlus__opPlus __tmp0 = (__opPlus__opPlus)__arg0;
            e = __tmp0.__arg0;
            el = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = e;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 35;
            }
            if (!(__tmp1.__res.Value is __opDollarl))
            {
              goto case 35;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            v = __tmp2.Value;

            eval __tmp3 = new eval();
            __tmp3.__arg0 = el;
            __tmp3.__arg1 = m;
            __tmp3.Run();
            if (!(__tmp3.__res.HasValue))
            {
              goto case 35;
            }
            if (!(__tmp3.__res.Value is __opDollarl))
            {
              goto case 35;
            }
            __MetaCnvResult<Value> __tmp4 = __tmp3.__res;
            __opDollarl __tmp5 = (__opDollarl)__tmp4.Value;
            li = __tmp5.__arg0;

            __opDollarl __tmp6 = new __opDollarl();
            __opColon__opColon<Value> __tmp7 = new __opColon__opColon<Value>();
            __tmp7.__arg0 = v;
            __tmp7.__arg1 = li;
            __tmp6.__arg0 = __tmp7;
            __res.HasValue = true;
            __res.Value = __tmp6;
            break;

          }
        case 35:
          {
            Expr ex = default(Expr);
            Expr ey = default(Expr);
            ctxt m = default(ctxt);
            Lists.List<Value> xs = default(Lists.List<Value>);
            Lists.List<Value> ys = default(Lists.List<Value>);
            Lists.List<Value> zs = default(Lists.List<Value>);

            if (!(__arg0 is __opAt))
            {
              goto case 36;
            }

            __opAt __tmp0 = (__opAt)__arg0;
            ex = __tmp0.__arg0;
            ey = __tmp0.__arg1;
            m = __arg1;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = ex;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 36;
            }
            if (!(__tmp1.__res.Value is __opDollarl))
            {
              goto case 36;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            __opDollarl __tmp3 = (__opDollarl)__tmp2.Value;
            xs = __tmp3.__arg0;

            eval __tmp4 = new eval();
            __tmp4.__arg0 = ey;
            __tmp4.__arg1 = m;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto case 36;
            }
            if (!(__tmp4.__res.Value is __opDollarl))
            {
              goto case 36;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp4.__res;
            __opDollarl __tmp6 = (__opDollarl)__tmp5.Value;
            ys = __tmp6.__arg0;

            append<Value> __tmp7 = new append<Value>();
            __tmp7.__arg0 = xs;
            __tmp7.__arg1 = ys;
            __tmp7.Run();
            if (!(__tmp7.__res.HasValue))
            {
              goto case 36;
            }
            __MetaCnvResult<Lists.List<Value>> __tmp8 = __tmp7.__res;
            zs = __tmp8.Value;

            __opDollarl __tmp9 = new __opDollarl();
            __tmp9.__arg0 = zs;
            __res.HasValue = true;
            __res.Value = __tmp9;
            break;
          }
        case 36:
          {
            Expr v = default(Expr);
            ctxt m = default(ctxt);
            float x = default(float);
            float y = default(float);
            if (!(__arg0 is vectorx))
            {
              goto case 37;
            }
            vectorx __tmp0 = (vectorx)__arg0;
            v = __tmp0.__arg0;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 37;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            if (!(__tmp2.Value is __opDollarVector2))
            {
              goto case 37;
            }
            __opDollarVector2 __tmp3 = (__opDollarVector2)__tmp2.Value;
            x = __tmp3.__arg0;
            y = __tmp3.__arg1;

            __opDollarf __tmp4 = new __opDollarf();
            __tmp4.__arg0 = x;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        case 37:
          {
            Expr v = default(Expr);
            ctxt m = default(ctxt);
            float x = default(float);
            float y = default(float);
            if (!(__arg0 is vectory))
            {
              goto case 37;
            }
            vectory __tmp0 = (vectory)__arg0;
            v = __tmp0.__arg0;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = m;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 37;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            if (!(__tmp2.Value is __opDollarVector2))
            {
              goto case 37;
            }
            __opDollarVector2 __tmp3 = (__opDollarVector2)__tmp2.Value;
            x = __tmp3.__arg0;
            y = __tmp3.__arg1;

            __opDollarf __tmp4 = new __opDollarf();
            __tmp4.__arg0 = y;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        case 38:
          {
            break;
          }
        default: break;
      }
    }
  }
}
