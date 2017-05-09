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
            k = __arg1;
            ctxt = __arg2;
            dt = __arg3;

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
        //nop
        case 7:
          {
            ctxt ctxt = default(ctxt);
            float dt = default(float);

            if (!(__arg0 is nop))
            {
              goto case 8;
            }
            nop __tmp0 = (nop)__arg0;
            if (!(__arg1 is nop))
            {
              goto case 8;
            }
            nop __tmp1 = (nop)__arg1;
            ctxt = __arg2;
            dt = __arg3;

            Done __tmp2 = new Done();
            __tmp2.__arg0 = ctxt;
            __res.HasValue = true;
            __res.Value = __tmp2;
            break;
          }
        case 8:
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

    public class evalRule
    {
      public Rule __arg0;
      public ImmutableDictionary<string, Value> __arg1;
      public ImmutableDictionary<string, Value> __arg2;
      public __MetaCnvResult<ExecutionResult> __res;

      public void Run()
      {
        int __ruleIndex = 0;
        __res = new __MetaCnvResult<ExecutionResult>();
        __res.Value = default(ExecutionResult);
        __res.HasValue = false;

        switch (__ruleIndex)
        {
          case 0:
            {
              Lists.List<string> dom = default(Lists.List<string>);
              stmt b = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              stmt z = default(stmt);
              ImmutableDictionary<string, Value> newLocals = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newGlobals = default(ImmutableDictionary<string, Value>);
              ExecutionResult res = default(ExecutionResult);
              if (!(__arg0 is rule))
              {
                goto case 1;
              }
              rule __tmp0 = (rule)__arg0;
              dom = __tmp0.__arg0;
              b = __tmp0.__arg1;
              k = __tmp0.__arg2;
              locals = __tmp0.__arg3;
              dt = __tmp0.__arg4;

              eval_s __tmp1 = new eval_s();
              __tmp1.__arg0 = b;
              __tmp1.__arg1 = k;
              Context __tmp2 = new Context();
              __tmp2.__arg0 = locals;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
              __tmp1.__arg2 = __tmp2;
              __tmp1.__arg3 = dt;
              __tmp1.Run();
              if(!(__tmp1.__res.HasValue))
              {
                goto case 1;
              }
              __MetaCnvResult<ExecutionResult> __tmp3 = __tmp1.__res;
              if(!(__tmp3.Value is Atomic))
              {
                goto case 1;
              }
              Atomic __tmp4 = (Atomic)__tmp3.Value;
              z = __tmp4.__arg0;
              if (!(__tmp4.__arg1 is Context))
              {
                goto case 1;
              }
              Context __tmp5 = (Context)__tmp4.__arg1;
              newLocals = __tmp5.__arg0;
              newFields = __tmp5.__arg1;
              newGlobals = __tmp5.__arg2;

              evalRule __tmp6 = new evalRule();
              rule __tmp7 = new rule();
              __tmp7.__arg0 = dom;
              __tmp7.__arg1 = z;
              nop __tmp8 = new nop();
              __tmp7.__arg2 = __tmp8;
              __tmp7.__arg3 = newLocals;
              __tmp7.__arg4 = dt;
              __tmp6.__arg0 = __tmp7;
              __tmp6.__arg1 = newFields;
              __tmp6.__arg2 = newGlobals;
              __tmp6.Run();
              if (!(__tmp6.__res.HasValue))
              {
                goto case 1;
              }
              __MetaCnvResult<ExecutionResult> __tmp9 = __tmp6.__res;
              res = __tmp9.Value;

              __res.HasValue = true;
              __res.Value = res;
              break;
            }
          case 1:
            {
              Lists.List<string> dom = default(Lists.List<string>);
              stmt b = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              ctxt context = default(ctxt);
              if (!(__arg0 is rule))
              {
                goto case 2;
              }
              rule __tmp0 = (rule)__arg0;
              dom = __tmp0.__arg0;
              b = __tmp0.__arg1;
              k = __tmp0.__arg2;
              locals = __tmp0.__arg3;
              dt = __tmp0.__arg4;

              eval_s __tmp1 = new eval_s();
              __tmp1.__arg0 = b;
              __tmp1.__arg1 = k;
              Context __tmp2 = new Context();
              __tmp2.__arg0 = locals;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
              __tmp1.__arg2 = __tmp2;
              __tmp1.__arg3 = dt;
              __tmp1.Run();
              if (!(__tmp1.__res.HasValue))
              {
                goto case 2;
              }
              __MetaCnvResult<ExecutionResult> __tmp3 = __tmp1.__res;
              if (!(__tmp3.Value is Done))
              {
                goto case 2;
              }
              Done __tmp4 = (Done)__tmp3.Value;
              context = __tmp4.__arg0;

              Done __tmp5 = new Done();
              __tmp5.__arg0 = context;
              __res.HasValue = true;
              __res.Value = __tmp5;
              break;
            }
          case 2:
            {
              Lists.List<string> dom = default(Lists.List<string>);
              stmt b = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              stmt ks = default(stmt);
              ctxt context = default(ctxt);
              if (!(__arg0 is rule))
              {
                goto case 3;
              }
              rule __tmp0 = (rule)__arg0;
              dom = __tmp0.__arg0;
              b = __tmp0.__arg1;
              k = __tmp0.__arg2;
              locals = __tmp0.__arg3;
              dt = __tmp0.__arg4;

              eval_s __tmp1 = new eval_s();
              __tmp1.__arg0 = b;
              __tmp1.__arg1 = k;
              Context __tmp2 = new Context();
              __tmp2.__arg0 = locals;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
              __tmp1.__arg2 = __tmp2;
              __tmp1.__arg3 = dt;
              __tmp1.Run();
              if (!(__tmp1.__res.HasValue))
              {
                goto case 3;
              }
              __MetaCnvResult<ExecutionResult> __tmp3 = __tmp1.__res;
              if (!(__tmp3.Value is Suspend))
              {
                goto case 3;
              }
              Suspend __tmp4 = (Suspend)__tmp3.Value;
              ks = __tmp4.__arg0;
              context = __tmp4.__arg1;

              Suspend __tmp5 = new Suspend();
              __tmp5.__arg0 = ks;
              __tmp5.__arg1 = context;
              __res.HasValue = true;
              __res.Value = __tmp5;
              break;
            }
          case 3:
            {
              Lists.List<string> dom = default(Lists.List<string>);
              stmt b = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              stmt ks = default(stmt);
              ctxt context = default(ctxt);
              if (!(__arg0 is rule))
              {
                goto case 4;
              }
              rule __tmp0 = (rule)__arg0;
              dom = __tmp0.__arg0;
              b = __tmp0.__arg1;
              k = __tmp0.__arg2;
              locals = __tmp0.__arg3;
              dt = __tmp0.__arg4;

              eval_s __tmp1 = new eval_s();
              __tmp1.__arg0 = b;
              __tmp1.__arg1 = k;
              Context __tmp2 = new Context();
              __tmp2.__arg0 = locals;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
              __tmp1.__arg2 = __tmp2;
              __tmp1.__arg3 = dt;
              __tmp1.Run();
              if (!(__tmp1.__res.HasValue))
              {
                goto case 4;
              }
              __MetaCnvResult<ExecutionResult> __tmp3 = __tmp1.__res;
              if (!(__tmp3.Value is Resume))
              {
                goto case 4;
              }
              Resume __tmp4 = (Resume)__tmp3.Value;
              ks = __tmp4.__arg0;
              context = __tmp4.__arg1;

              Resume __tmp5 = new Resume();
              __tmp5.__arg0 = ks;
              __tmp5.__arg1 = context;
              __res.HasValue = true;
              __res.Value = __tmp5;
              break;
            }
          case 4:
            {
              Lists.List<string> dom = default(Lists.List<string>);
              stmt b = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              stmt ks = default(stmt);
              Lists.List<Value> values = default(Lists.List<Value>);
              ctxt context = default(ctxt);
              ctxt updatedContext = default(ctxt);
              if (!(__arg0 is rule))
              {
                goto default;
              }
              rule __tmp0 = (rule)__arg0;
              dom = __tmp0.__arg0;
              b = __tmp0.__arg1;
              k = __tmp0.__arg2;
              locals = __tmp0.__arg3;
              dt = __tmp0.__arg4;

              eval_s __tmp1 = new eval_s();
              __tmp1.__arg0 = b;
              __tmp1.__arg1 = k;
              Context __tmp2 = new Context();
              __tmp2.__arg0 = locals;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
              __tmp1.__arg2 = __tmp2;
              __tmp1.__arg3 = dt;
              __tmp1.Run();
              if (!(__tmp1.__res.HasValue))
              {
                goto default;
              }
              __MetaCnvResult<ExecutionResult> __tmp3 = __tmp1.__res;
              if (!(__tmp3.Value is Yield))
              {
                goto default;
              }
              Yield __tmp4 = (Yield)__tmp3.Value;
              ks = __tmp4.__arg0;
              values = __tmp4.__arg1;
              context = __tmp4.__arg2;

              updateFields __tmp5 = new updateFields();
              __tmp5.__arg0 = dom;
              __tmp5.__arg1 = values;
              __tmp5.__arg2 = context;
              __tmp5.Run();
              if (!(__tmp5.__res.HasValue))
              {
                goto default;
              }
              __MetaCnvResult<ctxt> __tmp6 = __tmp5.__res;
              updatedContext = __tmp6.Value;

              Yield __tmp7 = new Yield();
              __tmp7.__arg0 = ks;
              __tmp7.__arg1 = values;
              __tmp7.__arg2 = updatedContext;
              break;
            }
          default: break;
        }
      }
    }

    public class updateFields
    {
      public Lists.List<string> __arg0;
      public Lists.List<Value> __arg1;
      public ctxt __arg2;
      public __MetaCnvResult<ctxt> __res;

      public void Run()
      {
        int __ruleIndex = 0;
        __res = new __MetaCnvResult<ctxt>();
        __res.Value = default(ctxt);
        __res.HasValue = false;

        switch (__ruleIndex)
        {
          case 0:
            {
              ctxt context = default(ctxt);
              if (!(__arg0 is nil<string>))
              {
                goto case 1;
              }
              nil<string> __tmp0 = (nil<string>)__arg0;
              if (!(__arg1 is nil<Value>))
              {
                goto case 1;
              }
              nil<Value> __tmp1 = (nil<Value>)__arg1;
              __res.HasValue = true;
              __res.Value = context;
              break;
            }
          case 1:
            {
              string f;
              Lists.List<string> fs;
              Value v;
              Lists.List<Value> vs;
              ImmutableDictionary<string, Value> l = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> e = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> w = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> updatedEntity = default(ImmutableDictionary<string, Value>);
              ctxt updatedContext = default(ctxt);
              if (!(__arg0 is __opColon__opColon<string>))
              {
                goto case 2;
              }
              __opColon__opColon<string> __tmp0 = (__opColon__opColon<string>)__arg0;
              f = __tmp0.__arg0;
              fs = __tmp0.__arg1;
              if (!(__arg1 is __opColon__opColon<Value>))
              {
                goto case 2;
              }
              __opColon__opColon<Value> __tmp1 = (__opColon__opColon<Value>)__arg1;
              v = __tmp1.__arg0;
              vs = __tmp1.__arg1;
              if(!(__arg2 is Context))
              {
                goto case 2;
              }
              Context __tmp2 = (Context)__arg2;
              l = __tmp2.__arg0;
              e = __tmp2.__arg1;
              w = __tmp2.__arg2;
              updatedEntity = e.SetItem(f, v);

              updateFields __tmp3 = new updateFields();
              __tmp3.__arg0 = fs;
              __tmp3.__arg1 = vs;
              Context __tmp4 = new Context();
              __tmp4.__arg0 = l;
              __tmp4.__arg1 = updatedEntity;
              __tmp4.__arg2 = w;
              __tmp3.__arg2 = __tmp4;
              __tmp3.Run();
              if (!(__tmp3.__res.HasValue))
              {
                goto case 2;
              }
              __MetaCnvResult<ctxt> __tmp5 = __tmp3.__res;
              updatedContext = __tmp5.Value;

              __res.HasValue = true;
              __res.Value = updatedContext;
              break;
            }
          case 2:
            {
              break;
            }
          default: break;
        }
      }
    }

    public class tick
    {
      public Lists.List<Rule> __arg0;
      public Lists.List<Rule> __arg1;
      public ImmutableDictionary<string, Value> __arg2 = default(ImmutableDictionary<string, Value>);
      public ImmutableDictionary<string, Value> __arg3 = default(ImmutableDictionary<string, Value>);
      public float __arg4;
      public __MetaCnvResult<GameState> __res;

      public void Run()
      {
        int __ruleIndex = 0;
        __res = new __MetaCnvResult<GameState>();
        __res.Value = default(GameState);
        __res.HasValue = false;

        switch (__ruleIndex)
        {
          case 0:
            {
              Rule original = default(Rule);
              Lists.List<Rule> originals = default(Lists.List<Rule>);
              Rule r = default(Rule);
              Lists.List<Rule> rs = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> newLocals = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newGlobals = default(ImmutableDictionary<string, Value>);
              Lists.List<Rule> updatedRules = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> updatedFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> updatedGlobals = default(ImmutableDictionary<string, Value>);
              State st = default(State);
              if (!(__arg0 is __opColon__opColon<Rule>))
              {
                goto case 1;
              }
              __opColon__opColon<Rule> __tmp0 = (__opColon__opColon<Rule>)__arg0;
              original = __tmp0.__arg0;
              originals = __tmp0.__arg1;
              if (!(__arg1 is __opColon__opColon<Rule>))
              {
                goto case 1;
              }
              __opColon__opColon<Rule> __tmp1 = (__opColon__opColon<Rule>)__arg1;
              r = __tmp1.__arg0;
              rs = __tmp1.__arg1;
              fields = __arg2;
              globals = __arg3;
              dt = __arg4;

              evalRule __tmp2 = new evalRule();
              __tmp2.__arg0 = r;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
                __tmp2.Run();
              if (!(__tmp2.__res.HasValue))
              {
                goto case 1;
              }
              __MetaCnvResult<ExecutionResult> __tmp3 = __tmp2.__res;
              if (!(__tmp3.Value is Done))
              {
                goto case 1;
              }
              Done __tmp4 = (Done)__tmp3.Value;
              if (!(__tmp4.__arg0 is Context))
              {
                goto case 1;
              }
              Context __tmp5 = (Context)__tmp4.__arg0;
              newLocals = __tmp5.__arg0;
              newFields = __tmp5.__arg1;
              newGlobals = __tmp5.__arg2;

              tick __tmp6 = new tick();
              __tmp6.__arg0 = originals;
              __tmp6.__arg1 = rs;
              __tmp6.__arg2 = newFields;
              __tmp6.__arg3 = newGlobals;
              __tmp6.__arg4 = dt;
              __tmp6.Run();

              if (!(__tmp6.__res.HasValue))
              {
                goto case 1;
              }
              __MetaCnvResult<GameState> __tmp7 = __tmp6.__res;
              if (!(__tmp7.Value is State))
              {
                goto case 1;
              }
              State __tmp8 = (State)__tmp7.Value;
              updatedRules = __tmp8.__arg0;
              updatedFields = __tmp8.__arg1;
              updatedGlobals = __tmp8.__arg2;
              State __tmp9 = new State();
              __opColon__opColon<Rule> __tmp10 = new __opColon__opColon<Rule>();
              __tmp10.__arg0 = original;
              __tmp10.__arg1 = updatedRules;
              __tmp9.__arg0 = __tmp10;
              __tmp9.__arg1 = updatedFields;
              __tmp9.__arg2 = updatedGlobals;
              st = __tmp9;

              __res.HasValue = true;
              __res.Value = st;
              break;
            }
          case 1:
            {
              Rule original = default(Rule);
              Lists.List<Rule> originals = default(Lists.List<Rule>);
              Lists.List<string> dom = default(Lists.List<string>);
              stmt body = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float delta = default(float);
              Lists.List<Rule> rs = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> newLocals = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newGlobals = default(ImmutableDictionary<string, Value>);
              Lists.List<Rule> updatedRules = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> updatedFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> updatedGlobals = default(ImmutableDictionary<string, Value>);
              State st = default(State);
              stmt s = default(stmt);
              stmt cont = default(stmt);
              rule r = default(rule);
              if (!(__arg0 is __opColon__opColon<Rule>))
              {
                goto case 2;
              }
              __opColon__opColon<Rule> __tmp0 = (__opColon__opColon<Rule>)__arg0;
              original = __tmp0.__arg0;
              originals = __tmp0.__arg1;
              if (!(__arg1 is __opColon__opColon<Rule>))
              {
                goto case 2;
              }
              __opColon__opColon<Rule> __tmp1 = (__opColon__opColon<Rule>)__arg1;
              if (!(__tmp1.__arg1 is rule))
              {
                goto case 2;
              }
              rule __tmp2 = (rule)__tmp1.__arg1;
              dom = __tmp2.__arg0;
              body = __tmp2.__arg1;
              k = __tmp2.__arg2;
              locals = __tmp2.__arg3;
              delta = __tmp2.__arg4;
              rs = __tmp1.__arg1;
              fields = __arg2;
              globals = __arg3;
              dt = __arg4;

              evalRule __tmp3 = new evalRule();
              rule __tmp4 = new rule();
              __tmp4.__arg0 = dom;
              __tmp4.__arg1 = body;
              __tmp4.__arg2 = k;
              __tmp4.__arg3 = locals;
              __tmp4.__arg4 = delta;
              __tmp3.__arg0 = __tmp4;
              __tmp3.__arg1 = fields;
              __tmp3.__arg2 = globals;
              __tmp3.Run();
              if (!(__tmp3.__res.HasValue))
              {
                goto case 2;
              }
              __MetaCnvResult<ExecutionResult> __tmp5 = __tmp3.__res;
              if (!(__tmp5.Value is Suspend))
              {
                goto case 2;
              }
              Suspend __tmp6 = (Suspend)__tmp5.Value;
              if (!(__tmp6.__arg0 is __opSemicolon))
              {
                goto case 2;
              }
              __opSemicolon __tmp7 = (__opSemicolon)__tmp6.__arg0;
              s = __tmp7.__arg0;
              cont = __tmp7.__arg1;
              if (!(__tmp6.__arg1 is Context))
              {
                goto case 2;
              }
              Context __tmp8 = (Context)__tmp6.__arg1;
              newLocals = __tmp8.__arg0;
              newFields = __tmp8.__arg1;
              newGlobals = __tmp8.__arg2;
              rule __tmp9 = new rule();
              __tmp9.__arg0 = dom;
              __tmp9.__arg1 = s;
              __tmp9.__arg2 = cont;
              __tmp9.__arg3 = newLocals;
              __tmp9.__arg4 = dt;
              r = __tmp9;

              tick __tmp10 = new tick();
              __tmp10.__arg0 = originals;
              __tmp10.__arg1 = rs;
              __tmp10.__arg2 = newFields;
              __tmp10.__arg3 = newGlobals;
              __tmp10.__arg4 = dt;
              __tmp10.Run();
              if (!(__tmp10.__res.HasValue))
              {
                goto case 2;
              }
              __MetaCnvResult<GameState> __tmp11 = __tmp10.__res;
              if (!(__tmp11.Value is State))
              {
                goto case 2;
              }
              State __tmp12 = (State)__tmp11.Value;
              updatedRules = __tmp12.__arg0;
              updatedFields = __tmp12.__arg1;
              updatedGlobals = __tmp12.__arg2;
              State __tmp13 = new State();
              __opColon__opColon<Rule> __tmp14 = new __opColon__opColon<Rule>();
              __tmp14.__arg0 = r;
              __tmp14.__arg1 = updatedRules;
              __tmp13.__arg0 = __tmp14;
              __tmp13.__arg1 = updatedFields;
              __tmp13.__arg1 = updatedGlobals;
              st = __tmp13;

              __res.HasValue = true;
              __res.Value = st;
              break;
            }
          case 2:
            {
              Rule original = default(Rule);
              Lists.List<Rule> originals = default(Lists.List<Rule>);
              Lists.List<string> dom = default(Lists.List<string>);
              stmt body = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float delta = default(float);
              Lists.List<Rule> rs = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> newLocals = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newGlobals = default(ImmutableDictionary<string, Value>);
              Lists.List<Rule> updatedRules = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> updatedFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> updatedGlobals = default(ImmutableDictionary<string, Value>);
              State st = default(State);
              stmt cont = default(stmt);
              rule r = default(rule);
              Lists.List<Value> values = default(Lists.List<Value>);
              if (!(__arg0 is __opColon__opColon<Rule>))
              {
                goto case 3;
              }
              __opColon__opColon<Rule> __tmp0 = (__opColon__opColon<Rule>)__arg0;
              original = __tmp0.__arg0;
              originals = __tmp0.__arg1;
              if (!(__arg1 is __opColon__opColon<Rule>))
              {
                goto case 3;
              }
              __opColon__opColon<Rule> __tmp1 = (__opColon__opColon<Rule>)__arg1;
              if (!(__tmp1.__arg1 is rule))
              {
                goto case 3;
              }
              rule __tmp2 = (rule)__tmp1.__arg1;
              dom = __tmp2.__arg0;
              body = __tmp2.__arg1;
              k = __tmp2.__arg2;
              locals = __tmp2.__arg3;
              delta = __tmp2.__arg4;
              rs = __tmp1.__arg1;
              fields = __arg2;
              globals = __arg3;
              dt = __arg4;

              evalRule __tmp3 = new evalRule();
              rule __tmp4 = new rule();
              __tmp4.__arg0 = dom;
              __tmp4.__arg1 = body;
              __tmp4.__arg2 = k;
              __tmp4.__arg3 = locals;
              __tmp4.__arg4 = delta;
              __tmp3.__arg0 = __tmp4;
              __tmp3.__arg1 = fields;
              __tmp3.__arg2 = globals;
              __tmp3.Run();
              if (!(__tmp3.__res.HasValue))
              {
                goto case 3;
              }
              __MetaCnvResult<ExecutionResult> __tmp5 = __tmp3.__res;
              if (!(__tmp5.Value is Yield))
              {
                goto case 3;
              }
              Yield __tmp6 = (Yield)__tmp5.Value;
              cont = __tmp6.__arg0;
              values = __tmp6.__arg1;
              if (!(__tmp6.__arg2 is Context))
              {
                goto case 3;
              }
              Context __tmp7 = (Context)__tmp6.__arg2;
              newLocals = __tmp7.__arg0;
              newFields = __tmp7.__arg1;
              newGlobals = __tmp7.__arg2;
              rule __tmp8 = new rule();
              __tmp8.__arg0 = dom;
              __tmp8.__arg1 = cont;
              nop __tmp9 = new nop();
              __tmp8.__arg2 = __tmp9;
              __tmp8.__arg3 = newLocals;
              __tmp8.__arg4 = dt;
              r = __tmp8;

              tick __tmp10 = new tick();
              __tmp10.__arg0 = originals;
              __tmp10.__arg1 = rs;
              __tmp10.__arg2 = newFields;
              __tmp10.__arg3 = newGlobals;
              __tmp10.__arg4 = dt;
              __tmp10.Run();
              if (!(__tmp10.__res.HasValue))
              {
                goto case 3;
              }
              __MetaCnvResult<GameState> __tmp11 = __tmp10.__res;
              if (!(__tmp11.Value is State))
              {
                goto case 3;
              }
              State __tmp12 = (State)__tmp11.Value;
              __tmp12.__arg0 = updatedRules;
              __tmp12.__arg1 = updatedFields;
              __tmp12.__arg2 = updatedGlobals;
              State __tmp13 = new State();
              __opColon__opColon<Rule> __tmp14 = new __opColon__opColon<Rule>();
              __tmp14.__arg0 = r;
              __tmp14.__arg1 = updatedRules;
              __tmp13.__arg0 = __tmp14;
              __tmp13.__arg1 = updatedFields;
              __tmp13.__arg2 = updatedGlobals;
              st = __tmp13;

              __res.HasValue = true;
              __res.Value = st;
              break;
            }
          case 3:
            {
              Rule original = default(Rule);
              Lists.List<Rule> originals = default(Lists.List<Rule>);
              Lists.List<string> dom = default(Lists.List<string>);
              stmt body = default(stmt);
              stmt k = default(stmt);
              ImmutableDictionary<string, Value> locals = default(ImmutableDictionary<string, Value>);
              float delta = default(float);
              Lists.List<Rule> rs = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              ImmutableDictionary<string, Value> newLocals = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> newGlobals = default(ImmutableDictionary<string, Value>);
              Lists.List<Rule> updatedRules = default(Lists.List<Rule>);
              ImmutableDictionary<string, Value> updatedFields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> updatedGlobals = default(ImmutableDictionary<string, Value>);
              State st = default(State);
              stmt cont = default(stmt);
              rule r = default(rule);
              if (!(__arg0 is __opColon__opColon<Rule>))
              {
                goto case 4;
              }
              __opColon__opColon<Rule> __tmp0 = (__opColon__opColon<Rule>)__arg0;
              original = __tmp0.__arg0;
              originals = __tmp0.__arg1;
              if (!(__arg1 is __opColon__opColon<Rule>))
              {
                goto case 4;
              }
              __opColon__opColon<Rule> __tmp1 = (__opColon__opColon<Rule>)__arg1;
              if (!(__tmp1.__arg1 is rule))
              {
                goto case 4;
              }
              rule __tmp2 = (rule)__tmp1.__arg1;
              dom = __tmp2.__arg0;
              body = __tmp2.__arg1;
              k = __tmp2.__arg2;
              locals = __tmp2.__arg3;
              delta = __tmp2.__arg4;
              rs = __tmp1.__arg1;
              fields = __arg2;
              globals = __arg3;
              dt = __arg4;

              evalRule __tmp3 = new evalRule();
              rule __tmp4 = new rule();
              __tmp4.__arg0 = dom;
              __tmp4.__arg1 = body;
              __tmp4.__arg2 = k;
              __tmp4.__arg3 = locals;
              __tmp4.__arg4 = delta;
              __tmp3.__arg0 = __tmp4;
              __tmp3.__arg1 = fields;
              __tmp3.__arg2 = globals;
              __tmp3.Run();
              if (!(__tmp3.__res.HasValue))
              {
                goto case 4;
              }
              __MetaCnvResult<ExecutionResult> __tmp5 = __tmp3.__res;
              if (!(__tmp5.Value is Resume))
              {
                goto case 4;
              }
              Resume __tmp6 = (Resume)__tmp5.Value;
              cont = __tmp6.__arg0;
              if (!(__tmp6.__arg1 is Context))
              {
                goto case 4;
              }
              Context __tmp7 = (Context)__tmp6.__arg1;
              newLocals = __tmp7.__arg0;
              newFields = __tmp7.__arg1;
              newGlobals = __tmp7.__arg2;
              rule __tmp8 = new rule();
              __tmp8.__arg0 = dom;
              __tmp8.__arg1 = cont;
              nop __tmp9 = new nop();
              __tmp8.__arg2 = __tmp9;
              __tmp8.__arg3 = newLocals;
              __tmp8.__arg4 = dt;
              r = __tmp8;

              tick __tmp10 = new tick();
              __tmp10.__arg0 = originals;
              __tmp10.__arg1 = rs;
              __tmp10.__arg2 = newFields;
              __tmp10.__arg3 = newGlobals;
              __tmp10.__arg4 = dt;
              __tmp10.Run();
              if (!(__tmp10.__res.HasValue))
              {
                goto case 4;
              }
              __MetaCnvResult<GameState> __tmp11 = __tmp10.__res;
              if (!(__tmp11.Value is State))
              {
                goto case 4;
              }
              State __tmp12 = (State)__tmp11.Value;
              __tmp12.__arg0 = updatedRules;
              __tmp12.__arg1 = updatedFields;
              __tmp12.__arg2 = updatedGlobals;
              State __tmp13 = new State();
              __opColon__opColon<Rule> __tmp14 = new __opColon__opColon<Rule>();
              __tmp14.__arg0 = r;
              __tmp14.__arg1 = updatedRules;
              __tmp13.__arg0 = __tmp14;
              __tmp13.__arg1 = updatedFields;
              __tmp13.__arg2 = updatedGlobals;
              st = __tmp13;

              __res.HasValue = true;
              __res.Value = st;
              break;
            }
          case 4:
            {
              ImmutableDictionary<string, Value> fields = default(ImmutableDictionary<string, Value>);
              ImmutableDictionary<string, Value> globals = default(ImmutableDictionary<string, Value>);
              float dt = default(float);
              if (!(__arg0 is nil<Rule>))
              {
                goto default;
              }
              nil<Rule> __tmp0 = (nil<Rule>)__arg0;
              if (!(__arg1 is nil<Rule>))
              {
                goto default;
              }
              nil<Rule> __tmp1 = (nil<Rule>)__arg1;
              fields = __arg2;
              globals = __arg3;
              dt = __arg4;

              State __tmp2 = new State();
              nil<Rule> __tmp3 = new nil<Rule>();
              __tmp2.__arg0 = __tmp3;
              __tmp2.__arg1 = fields;
              __tmp2.__arg2 = globals;
              __res.HasValue = true;
              __res.Value = __tmp2;
              break;
            }
          default:break;
        }
      }
    }
  }
}
