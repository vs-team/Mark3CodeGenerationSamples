using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using Basics;
using Lists;
using MetaCnvInternals;

namespace Statements
{
  public interface EQ { }
  public interface Then { }
  public interface Else { }
  public interface stmt { }
  public interface Rule { }
  public interface Unit { }
  public interface Let : stmt { }
  public interface GameState { }
  public interface ExecutionResult { }

  public class __opEquals : EQ
  {
    public string __name = "=";

    public override string ToString()
    {
      return __name;
    }
  }

  public class then : Then
  {
    public string __name = "then";

    public override string ToString()
    {
      return __name;
    }
  }

  public class __else : Else
  {
    public string __name = "else";

    public override string ToString()
    {
      return __name;
    }
  }

  public class nop : stmt
  {
    public string __name = "nop";

    public override string ToString()
    {
      return __name;
    }
  }

  public class __opSemicolon : stmt
  {
    public string __name = ";";
    public stmt __arg0;
    public stmt __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }

  }

  public class let : Let
  {
    public string __name = "let";
    public ID __arg0;
    public EQ __arg1;
    public Expr __arg2;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + " " + __arg2 + ")";
    }
  }

  public class wait : stmt
  {
    public string __name = "wait";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }

  }

  public class when : stmt
  {
    public string __name = "when";
    public Expr __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }

  }

  public class yield : stmt
  {
    public string __name = "yield";
    public Lists.List<Expr> __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class rule : Rule
  {
    public string __name = "rule";
    public Lists.List<string> __arg0;
    public stmt __arg1;
    public stmt __arg2;
    public ImmutableDictionary<string, Value> __arg3;
    public float __arg4;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + " " + __arg2 + " " + __arg3 + " " + __arg4 + ")";
    }
  }

  public class unit : Unit
  {
    public string __name = "unit";

    public override string ToString()
    {
      return __name;
    }
  }

  public class State : GameState
  {
    public string __name = "State";
    public Lists.List<Rule> __arg0;
    public ImmutableDictionary<string, Value> __arg1;
    public ImmutableDictionary<string, Value> __arg2;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + " " + __arg2 + ")";
    }
  }

  public class Done : ExecutionResult
  {
    public string __name = "Done";
    public ctxt __arg0;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + ")";
    }
  }

  public class Suspend : ExecutionResult
  {
    public string __name = "Suspend";
    public stmt __arg0;
    public ctxt __arg1;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + ")";
    }
  }

  public class Yield : ExecutionResult
  {
    public string __name = "Yield";
    public stmt __arg0;
    public Lists.List<Value> __arg1;
    public ctxt __arg2;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + " " +__arg2 + ")";
    }
  }

  public class Resume : ExecutionResult
  {
    public string __name = "Resume";
    public stmt __arg0;
    public ctxt __arg1;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + ")";
    }
  }

  public class Atomic : ExecutionResult
  {
    public string __name = "Atomic";
    public stmt __arg0;
    public ctxt __arg1;

    public override string ToString()
    {
      return "(" + __name + " " + __arg0 + " " + __arg1 + ")";
    }
  }

  public class eval_s
  {
    public stmt __arg0;
    public stmt __arg1;
    public ctxt __arg2;
    public float __arg3;
    public __MetaCnvResult<ExecutionResult> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<ExecutionResult>();
      __res.Value = default(ExecutionResult);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        //let
        case 0:
          {
            string a = default(string);
            Expr b = default(Expr);
            stmt k = default(stmt);
            ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> e = default(ImmutableDictionary<string, Value>);
            ImmutableDictionary<string, Value> w = default(ImmutableDictionary<string, Value>);
            float dt = default(float);
            Value c = default(Value);
            ImmutableDictionary<string, Value> res = default(ImmutableDictionary<string, Value>);
            if (!(__arg0 is let))
            {
              goto case 1;
            }
            let __tmp0 = (let)__arg0;
            if (!(__tmp0.__arg0 is __opDollar))
            {
              goto case 1;
            }
            __opDollar __tmp1 = (__opDollar)__tmp0.__arg0;
            a = __tmp1.__arg0;
            b = __tmp0.__arg2;
            k = __arg1;
            if (!(__arg2 is Context))
            {
              goto case 1;
            }
            Context __tmp2 = (Context)__arg2;
            locals = __tmp2.__arg0;
            e = __tmp2.__arg1;
            w = __tmp2.__arg2;
            dt = __arg3;

            eval __tmp3 = new eval();
            __tmp3.__arg0 = b;
            Context __tmp4 = new Context();
            __tmp4.__arg0 = locals;
            __tmp4.__arg1 = e;
            __tmp4.__arg2 = w;
            __tmp3.__arg1 = __tmp4;
            __tmp3.Run();
            if (!(__tmp3.__res.HasValue))
            {
              goto case 1;
            }
            __MetaCnvResult<Value> __tmp5 = __tmp3.__res;
            c = __tmp5.Value;
            res = locals.SetItem(a, c);

            Atomic __tmp6 = new Atomic();
            __tmp6.__arg0 = k;
            Context __tmp7 = new Context();
            __tmp7.__arg0 = res;
            __tmp7.__arg1 = e;
            __tmp7.__arg2 = w;
            __tmp6.__arg1 = __tmp7;
            __res.HasValue = true;
            __res.Value = __tmp6;
            break;
          }
        //wait
        case 1:
          {
            Expr expr = default(Expr);
            stmt k = default(stmt);
            ctxt ctxt = default(ctxt);
            float dt = default(float);
            float t;

            if (!(__arg0 is wait))
            {
              goto case 2;
            }
            wait __tmp0 = (wait)__arg0;
            expr = __tmp0.__arg0;
            k = __arg1;
            ctxt = __arg2;
            dt = __arg3;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = expr;
            __tmp1.__arg1 = ctxt;
            __tmp1.Run();
            if(!(__tmp1.__res.HasValue))
            {
              goto case 2;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            if(!(__tmp2.Value is __opDollarf))
            {
              goto case 2;
            }
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            t = __tmp3.__arg0;
            if (!((t <= dt) == false))
            {
              goto case 2;
            }
            Suspend __tmp4 = new Suspend();
            __opSemicolon __tmp5 = new __opSemicolon();
            wait __tmp6 = new wait();
            __opDollarf __tmp7 = new __opDollarf();
            __tmp7.__arg0 = t - dt;
            __tmp6.__arg0 = __tmp7;
            __tmp5.__arg0 = __tmp6;
            __tmp5.__arg1 = k;
            __tmp4.__arg0 = __tmp5;
            __tmp4.__arg1 = ctxt;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        //wait
        case 2:
          {
            Expr expr = default(Expr);
            stmt k = default(stmt);
            ctxt ctxt = default(ctxt);
            float dt = default(float);
            float t;

            if (!(__arg0 is wait))
            {
              goto case 3;
            }
            wait __tmp0 = (wait)__arg0;
            expr = __tmp0.__arg0;
            k = __arg1;
            ctxt = __arg2;
            dt = __arg3;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = expr;
            __tmp1.__arg1 = ctxt;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 3;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            if (!(__tmp2.Value is __opDollarf))
            {
              goto case 3;
            }
            __opDollarf __tmp3 = (__opDollarf)__tmp2.Value;
            t = __tmp3.__arg0;
            if (!((t <= dt) == true))
            {
              goto case 3;
            }
            Resume __tmp4 = new Resume();
            __tmp4.__arg0 = k;
            __tmp4.__arg1 = ctxt;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        //when
        case 3:
          {
            Expr expr = default(Expr);
            stmt k = default(stmt);
            ctxt ctxt = default(ctxt);
            float dt = default(float);

            if (!(__arg0 is when))
            {
              goto case 4;
            }
            when __tmp0 = (when)__arg0;
            expr = __tmp0.__arg0;
            k = __arg1;
            ctxt = __arg2;
            dt = __arg3;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = expr;
            __tmp1.__arg1 = ctxt;
            __tmp1.Run();
            if(!(__tmp1.__res.HasValue))
            {
              goto case 4;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            if(!(__tmp2.Value is __opDollarb))
            {
              goto case 4;
            }
            __opDollarb __tmp3 = (__opDollarb)__tmp2.Value;
            if (__tmp3.__arg0 != true)
            {
              goto case 4;
            }

            Atomic __tmp4 = new Atomic();
            __tmp4.__arg0 = k;
            __tmp4.__arg1 = ctxt;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        //when
        case 4:
          {
            Expr expr = default(Expr);
            stmt k = default(stmt);
            ctxt ctxt = default(ctxt);
            float dt = default(float);

            if (!(__arg0 is when))
            {
              goto case 5;
            }
            when __tmp0 = (when)__arg0;
            expr = __tmp0.__arg0;
            k = __arg1;
            ctxt = __arg2;
            dt = __arg3;

            eval __tmp1 = new eval();
            __tmp1.__arg0 = expr;
            __tmp1.__arg1 = ctxt;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 5;
            }
            __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
            if (!(__tmp2.Value is __opDollarb))
            {
              goto case 5;
            }
            __opDollarb __tmp3 = (__opDollarb)__tmp2.Value;
            if (__tmp3.__arg0 != false)
            {
              goto case 5;
            }

            Suspend __tmp4 = new Suspend();
            __opSemicolon __tmp5 = new __opSemicolon();
            when __tmp6 = new when();
            __tmp6.__arg0 = expr;
            __tmp5.__arg0 = __tmp6;
            __tmp5.__arg1 = k;
            __tmp4.__arg0 = __tmp5;
            __tmp4.__arg1 = ctxt;
            __res.HasValue = true;
            __res.Value = __tmp4;
            break;
          }
        //yield
        case 5:
          {
            Lists.List<Expr> exprs = default(Lists.List<Expr>);
            stmt k = default(stmt);
            ctxt ctxt = default(ctxt);
            float dt = default(float);
            Lists.List<Value> values = default(Lists.List<Value>);

            if (!(__arg0 is yield))
            {
              goto case 6;
            }
            yield __tmp0 = (yield)__arg0;
            exprs = __tmp0.__arg0;

            evalYield __tmp1 = new evalYield();
            __tmp1.__arg0 = exprs;
            __tmp1.__arg1 = ctxt;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 6;
            }
            __MetaCnvResult<Lists.List<Value>> __tmp2 = __tmp1.__res;
            values = __tmp2.Value;

            Yield __tmp3 = new Yield();
            __tmp3.__arg0 = k;
            __tmp3.__arg1 = values;
            __tmp3.__arg2 = ctxt;
            __res.HasValue = true;
            __res.Value = __tmp3;
            break;
          }
        //a;b
        case 6:
          {
            stmt a = default(stmt);
            stmt b = default(stmt);
            stmt k = default(stmt);
            ctxt ctxt = default(ctxt);
            float dt = default(float);
            stmt cont = default(stmt);
            ExecutionResult res = default(ExecutionResult);

            if (!(__arg0 is __opSemicolon))
            {
              goto case 7;
            }
            __opSemicolon __tmp0 = (__opSemicolon)__arg0;
            k = __arg1;
            ctxt = __arg2;
            dt = __arg3;

            addStmt __tmp1 = new addStmt();
            __tmp1.__arg0 = b;
            __tmp1.__arg1 = k;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto case 7;
            }
            __MetaCnvResult<stmt> __tmp2 = __tmp1.__res;
            cont = __tmp2.Value;

            eval_s __tmp3 = new eval_s();
            __tmp3.__arg0 = a;
            __tmp3.__arg1 = cont;
            __tmp3.__arg2 = ctxt;
            __tmp3.__arg3 = dt;
            __tmp3.Run();
            if (!(__tmp3.__res.HasValue))
            {
              goto case 7;
            }
            __MetaCnvResult<ExecutionResult> __tmp4 = __tmp3.__res;
            res = __tmp4.Value;
            __res.HasValue = true;
            __res.Value = res;
            break;
          }
        case 7:
          {
            break;
          }
        default: break;
      }
    }

    public class addStmt
    {
      public stmt __arg0;
      public stmt __arg1;
      public __MetaCnvResult<stmt> __res;

      public void Run()
      {
        int __ruleIndex = 0;
        __res = new __MetaCnvResult<stmt>();
        __res.Value = default(stmt);
        __res.HasValue = false;

        switch (__ruleIndex)
        {
          case 0:
            {
              stmt a = default(stmt);
              stmt b = default(stmt);

              if (!(!(a is nop)))
              {
                goto case 1;
              }

              __opSemicolon __tmp0 = new __opSemicolon();
              __tmp0.__arg0 = a;
              __tmp0.__arg1 = b;
              __res.HasValue = true;
              __res.Value = __tmp0;
              break;
            }
          case 1:
            {
              if(!(__arg0 is nop))
              {
                goto default;
              }
              nop __tmp0 = (nop)__arg0;
              if(!(__arg0 is nop))
              {
                goto default;
              }
              nop __tmp1 = (nop)__arg1;

              nop __tmp2 = new nop();
              __res.HasValue = true;
              __res.Value = __tmp2;
              break;
            }
          default: break;
        }
      }
    }

    public class evalYield
    {
      public Lists.List<Expr> __arg0;
      public ctxt __arg1;
      public __MetaCnvResult<Lists.List<Value>> __res;

      public void Run()
      {
        int __ruleIndex = 0;
        __res = new __MetaCnvResult<Lists.List<Value>>();
        __res.Value = default(Lists.List<Value>);
        __res.HasValue = false;

        switch (__ruleIndex)
        {
          case 0:
            {
              ctxt ctxt = default(ctxt);
              if(!(__arg0 is Lists.nil<Expr>))
              {
                goto case 1;
              }
              Lists.nil<Expr> __tmp0 = (Lists.nil<Expr>)__arg0;
              ctxt = __arg1;

              Lists.nil<Value> __tmp1 = new Lists.nil<Value>();
              __res.HasValue = true;
              __res.Value = __tmp1;
              break;
            }
          case 1:
            {
              Expr expr = default(Expr);
              Lists.List<Expr> exprs = default(Lists.List<Expr>);
              ctxt ctxt = default(ctxt);
              Value v = default(Value);
              Lists.List<Value> vs = default(Lists.List<Value>);

              if(!(__arg0 is __opColon__opColon<Expr>))
              {
                goto default;
              }
              __opColon__opColon<Expr> __tmp0 = (__opColon__opColon<Expr>)__arg0;
              expr = __tmp0.__arg0;
              exprs = __tmp0.__arg1;
              ctxt = __arg1;

              eval __tmp1 = new eval();
              __tmp1.__arg0 = expr;
              __tmp1.__arg1 = ctxt;
              __tmp1.Run();
              if (!(__tmp1.__res.HasValue))
              {
                goto default;
              }
              __MetaCnvResult<Value> __tmp2 = __tmp1.__res;
              v = __tmp2.Value;

              evalYield __tmp3 = new evalYield();
              __tmp3.__arg0 = exprs;
              __tmp3.__arg1 = ctxt;
              __tmp3.Run();
              if (!(__tmp3.__res.HasValue))
              {
                goto default;
              }
              __MetaCnvResult<Lists.List<Value>> __tmp4 = __tmp3.__res;
              vs = __tmp4.Value;

              __opColon__opColon<Value> __tmp5 = new __opColon__opColon<Value>();
              __tmp5.__arg0 = v;
              __tmp5.__arg1 = vs;
              __res.HasValue = true;
              __res.Value = __tmp5;
              break;
            }
          default: break;
        }
      }
    }
  }
}
