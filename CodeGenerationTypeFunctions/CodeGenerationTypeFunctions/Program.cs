using System;
using Lists;
using Tuples;
using MetaCnvInternals;
using Basics;
using Statements;
using Record;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace CodeGenerationTypeFunctions
{
  public class run
  {
    public float __arg0;
    public __MetaCnvResult<GameState> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<GameState>();
      __res.HasValue = false;
      __res.Value = default(GameState);


      switch (__ruleIndex)
      {
        case 0:
          {
            float dt = default(float);
            dt = __arg0;
            __opDollarVector2 p = new __opDollarVector2();
            p.__arg0 = 1.0f;
            p.__arg1 = 1.0f;
            __opDollarVector2 vx = new __opDollarVector2();
            vx.__arg0 = 1.0f;
            vx.__arg1 = 0.0f;
            __opDollarVector2 vx1 = new __opDollarVector2();
            vx1.__arg0 = -1.0f;
            vx1.__arg1 = 0.0f;
            __opDollarVector2 vy = new __opDollarVector2();
            vy.__arg0 = 0.0f;
            vy.__arg1 = 1.0f;
            when s1 = new when();
            __opDollar __tmp0 = new __opDollar();
            __tmp0.__arg0 = "Position";
            vectorx __tmp1 = new vectorx();
            __tmp1.__arg0 = __tmp0;
            lt __tmp2 = new lt();
            __tmp2.__arg0 = __tmp1;
            __opDollarf __tmp3 = new __opDollarf();
            __tmp3.__arg0 = 30.0f;
            __tmp2.__arg1 = __tmp3;
            s1.__arg0 = __tmp2;
            yield s2 = new yield();
            __opColon__opColon<Expr> __tmp4 = new __opColon__opColon<Expr>();
            __tmp4.__arg0 = vx;
            __tmp4.__arg1 = new nil<Expr>();
            s2.__arg0 = __tmp4;
            when s3 = new when();
            __opDollar __tmp5 = new __opDollar();
            __tmp5.__arg0 = "Position";
            vectorx __tmp6 = new vectorx();
            __tmp6.__arg0 = __tmp0;
            gt __tmp7 = new gt();
            __tmp7.__arg0 = __tmp1;
            __opDollarf __tmp8 = new __opDollarf();
            __tmp8.__arg0 = 0.0f;
            __tmp7.__arg1 = __tmp8;
            s3.__arg0 = __tmp7;
            yield s4 = new yield();
            __opColon__opColon<Expr> __tmp9 = new __opColon__opColon<Expr>();
            __tmp9.__arg0 = vx1;
            __tmp9.__arg1 = new nil<Expr>();
            s4.__arg0 = __tmp9;
            yield s5 = new yield();
            __opColon__opColon<Expr> __tmp10 = new __opColon__opColon<Expr>();
            __opPlus __tmp11 = new __opPlus();
            __opDollar __tmp12 = new __opDollar();
            __opDollar __tmp13 = new __opDollar();
            __tmp12.__arg0 = "Position";
            __tmp13.__arg0 = "Velocity";
            __tmp11.__arg0 = __tmp12;
            __tmp11.__arg1 = __tmp13;
            __tmp10.__arg0 = __tmp11;
            __tmp10.__arg1 = new nil<Expr>();
            s5.__arg0 = __tmp10;
            ImmutableDictionary<string, Value> dict1 = ImmutableDictionary<string, Value>.Empty.Add("Position", p);
            ImmutableDictionary<string, Value> dict = dict1.Add("Velocity", vx);

            //r1
            __opColon__opColon<string> __r1tmp0 = new __opColon__opColon<string>();
            __r1tmp0.__arg0 = "Velocity";
            __r1tmp0.__arg1 = new nil<string>();
            __opSemicolon __r1tmp1 = new __opSemicolon();
            __r1tmp1.__arg0 = s1;
            __r1tmp1.__arg1 = s2;
            rule r1 = new rule();
            r1.__arg0 = __r1tmp0;
            r1.__arg1 = __r1tmp1;
            r1.__arg2 = new nop();
            r1.__arg3 = ImmutableDictionary<string, Value>.Empty;
            r1.__arg4 = dt;

            //r2
            __opColon__opColon<string> __r2tmp0 = new __opColon__opColon<string>();
            __r2tmp0.__arg0 = "Velocity";
            __r2tmp0.__arg1 = new nil<string>();
            __opSemicolon __r2tmp1= new __opSemicolon();
            __r2tmp1.__arg0 = s3;
            __r2tmp1.__arg1 = s4;
            rule r2 = new rule();
            r2.__arg0 = __r2tmp0;
            r2.__arg1 = __r2tmp1;
            r2.__arg2 = new nop();
            r2.__arg3 = ImmutableDictionary<string, Value>.Empty;
            r2.__arg4 = dt;

            //r3
            __opColon__opColon<string> __r3tmp0 = new __opColon__opColon<string>();
            __r3tmp0.__arg0 = "Position";
            __r3tmp0.__arg1 = new nil<string>();
            rule r3 = new rule();
            r3.__arg0 = __r3tmp0;
            r3.__arg1 = s5;
            r3.__arg2 = new nop();
            r3.__arg3 = ImmutableDictionary<string, Value>.Empty;
            r3.__arg4 = dt;

            tick __tick = new tick();
            __opColon__opColon<Rule> __ticktmp0 = new __opColon__opColon<Rule>();
            __opColon__opColon<Rule> __ticktmp1 = new __opColon__opColon<Rule>();
            __opColon__opColon<Rule> __ticktmp2 = new __opColon__opColon<Rule>();
            __ticktmp2.__arg0 = r3;
            __ticktmp2.__arg1 = new nil<Rule>();
            __ticktmp1.__arg0 = r2;
            __ticktmp1.__arg1 = __ticktmp2;
            __ticktmp0.__arg0 = r3;//r1;
            __ticktmp0.__arg1 = new nil<Rule>();//__ticktmp1;

            __opColon__opColon<Rule> __ticktmp3 = new __opColon__opColon<Rule>();
            __opColon__opColon<Rule> __ticktmp4 = new __opColon__opColon<Rule>();
            __opColon__opColon<Rule> __ticktmp5 = new __opColon__opColon<Rule>();
            __ticktmp5.__arg0 = r3;
            __ticktmp5.__arg1 = new nil<Rule>();
            __ticktmp4.__arg0 = r2;
            __ticktmp4.__arg1 = __ticktmp5;
            __ticktmp3.__arg0 = r3;//r1;
            __ticktmp3.__arg1 = new nil<Rule>();//__ticktmp4;

            __tick.__arg0 = __ticktmp0;
            __tick.__arg1 = __ticktmp3;
            __tick.__arg2 = dict;
            __tick.__arg3 = ImmutableDictionary<string, Value>.Empty;
            __tick.__arg4 = dt;
            __tick.Run();

            if (!(__tick.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<GameState> __restmp0 = __tick.__res;
            GameState __restmp1 = __restmp0.Value;
            __res.HasValue = true;
            __res.Value = __restmp1;
            break;
          }
        default: break;
      }

     
    }


  }

#if WINDOWS || LINUX
  public static class Program
  {

    static __opColon__opColon<a> MakeList<a>(a[] arr)
    {
      __opColon__opColon<a> l = new __opColon__opColon<a>();
      __opColon__opColon<a> __tmp = new __opColon__opColon<a>();
      l = __tmp;

      for (int i = 0; i < arr.Length - 1; i++)
      {
        __tmp.__arg0 = arr[i];
        __tmp.__arg1 = new __opColon__opColon<a>();
        __tmp = (__opColon__opColon<a>)__tmp.__arg1;
      }
      __tmp.__arg0 = arr[arr.Length - 1];
      __tmp.__arg1 = new nil<a>();

      return l;
    }

    static void TestList()
    {
      __opColon__opColon<int> test = MakeList<int>(new int[] { 5, 3, 2 });
      __opColon__opColon<int> addTest = MakeList<int>(new int[] { 1, 6 });

      length<int> __tmp0 = new length<int>();
      __tmp0.__arg0 = test;
      __tmp0.Run();

      append<int> __tmp1 = new append<int>();
      __tmp1.__arg0 = test;
      __tmp1.__arg1 = addTest;
      __tmp1.Run();

      if (__tmp0.__res.HasValue) Console.WriteLine(__tmp0.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");

      if (__tmp1.__res.HasValue) Console.WriteLine(__tmp1.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");
    }

    static void TestTuple()
    {
      __opComma<int, string> test = new __opComma<int, string>();
      test.__arg0 = 5;
      test.__arg1 = "Five";

      fst<int, string> __tmp0 = new fst<int, string>();
      __tmp0.__arg0 = test;
      __tmp0.Run();

      snd<int, string> __tmp1 = new snd<int, string>();
      __tmp1.__arg0 = test;
      __tmp1.Run();

      if (__tmp0.__res.HasValue) Console.WriteLine(__tmp0.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");

      if (__tmp1.__res.HasValue) Console.WriteLine(__tmp1.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");
    }

    static void TestExpr()
    {
      var e1 = new __opDollarVector2();
      var e2 = new __opDollarVector2();
      var e3 = new __opDollarVector2();
      var plus = new __opPlus();
      var minus = new __opMinus();

      e1.__arg0 = 5;
      e1.__arg1 = 15;
      e2.__arg0 = 4;
      e2.__arg1 = 16;
      e3.__arg0 = 2;
      e3.__arg1 = 15;

      //(e1 + e2) - e3
      plus.__arg0 = e1;
      plus.__arg1 = e2;
      minus.__arg0 = plus;
      minus.__arg1 = e3;

      Context m = new Context();
      m.__arg0 = ImmutableDictionary<string, Value>.Empty;
      m.__arg1 = ImmutableDictionary<string, Value>.Empty;
      m.__arg2 = ImmutableDictionary<string, Value>.Empty;

      eval ev = new eval();
      ev.__arg0 = minus;
      ev.__arg1 = m;
      ev.Run();

      //5 * (3 - 2)
      __opMul mulint = new __opMul();
      __opMinus minint = new __opMinus();
      mulint.__arg0 = new __opDollari();
      __opDollari eint1 = new __opDollari();
      __opDollari eint2 = new __opDollari();
      __opDollari eint3 = new __opDollari();
      eint1.__arg0 = 5;
      eint2.__arg0 = 3;
      eint3.__arg0 = 2;
      minint.__arg0 = eint2;
      minint.__arg1 = eint3;
      mulint.__arg0 = eint1;
      mulint.__arg1 = minint;

      eval evint = new eval();
      evint.__arg0 = mulint;
      evint.__arg1 = m;
      evint.Run();

      if (ev.__res.HasValue) Console.WriteLine(ev.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");

      if (evint.__res.HasValue) Console.WriteLine(evint.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");
    }

    const int minUpdates = 100;
    const int updates = 1000000;
    const string fileHeader = "RECORDS, FIELDS, TIME\n";

    static void TestDynamicTable()
    {
      long time = 0;
      Stopwatch watch = new Stopwatch();
      Random r = new Random();
      string fileContent = fileHeader;
      ImmutableDictionary<int, int> dynamicTable = ImmutableDictionary<int, int>.Empty;
      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine("Running dynamic table with " + i + " fields...");
        for (int u = minUpdates; u <= updates; u *= 10)
        {
          int[] keys = new int[i];
          for (int d = 0; d < i; d++)
          {
            keys[d] = r.Next();
            dynamicTable = dynamicTable.Add(keys[d], r.Next(-100, 100));
          }
          watch.Restart();
          for (int j = 0; j < u; j++)
          {
            dynamicTable.Last();
          }
          watch.Stop();
          time += watch.ElapsedMilliseconds;
          fileContent += i + "," + u + "," + ((double)watch.ElapsedMilliseconds / updates) + "\n";
        }
        Console.WriteLine("Done");
      }
      if (!System.IO.Directory.Exists("Benchmark"))
        System.IO.Directory.CreateDirectory("Benchmark");
      System.IO.File.WriteAllText("Benchmark\\benchmark_dynamic_table.csv", fileContent);
    }

    static void TestFunctors()
    {
      long time = 0;
      string fileContent = fileHeader;
      Stopwatch watch = new Stopwatch();
      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine("Running meta-records with " + i + " fields...");
        for (int u = minUpdates; u <= updates; u *= 10)
        {
          watch.Restart();
          for (int j = 0; j < u; j++)
          {
            TestRecord.TestRecords(i);
          }
          watch.Stop();
          time += watch.ElapsedMilliseconds;
          fileContent += i + "," + u + "," + ((double)watch.ElapsedMilliseconds / updates) + "\n";
        }
        Console.WriteLine("Done");
      }
      if (!System.IO.Directory.Exists("Benchmark"))
        System.IO.Directory.CreateDirectory("Benchmark");
      System.IO.File.WriteAllText("Benchmark\\benchmark_functors.csv", fileContent);
    }

    static void Main()
    {
      TestFunctors();
      TestDynamicTable();
    }
  }
#endif
}
