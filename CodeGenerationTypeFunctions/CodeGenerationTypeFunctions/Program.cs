using System;
using Lists;
using Tuples;
using Basics;
using System.Collections.Immutable;

namespace CodeGenerationTypeFunctions
{
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

      if (ev.__res.HasValue) Console.WriteLine(ev.__res.Value);
      else Console.WriteLine("The rule has failed its evaluation");
    }

    [STAThread]
    static void Main()
    {
      //TestList();
      //TestTuple();
      TestExpr();

      //using (var game = new Game1())
      //    game.Run();
    }
  }
#endif
}
