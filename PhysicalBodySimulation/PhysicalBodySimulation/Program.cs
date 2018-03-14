using Tuple;
using List;
using Internals;
using System.Diagnostics;
using System.IO;


namespace PhysicalBodySimulation
{
  class Program
  {
    static Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> makeTestBody()
    {
      __opComma<float, float> fst;
      unit unit;
      __opComma<Tuple<float, float>, Unit> acceleration = new __opComma<Tuple<float, float>, Unit>();
      fst = new __opComma<float, float>();
      unit = new unit();
      fst.__arg0 = 0.5f;
      fst.__arg1 = 0.5f;
      acceleration.__arg0 = fst;
      acceleration.__arg1 = unit;
      __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> velocity = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>();
      fst = new __opComma<float, float>();
      fst.__arg0 = 1f;
      fst.__arg1 = 1f;
      velocity.__arg0 = fst;
      velocity.__arg1 = acceleration;
      __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> position = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
      fst = new __opComma<float, float>();
      fst.__arg0 = 2f;
      fst.__arg1 = 3f;
      position.__arg0 = fst;
      position.__arg1 = velocity;
      return position;
    }

    static void TestSettersAndGetters()
    {
      Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> testBody = makeTestBody();
      Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedBody;

      //get position
      GetField0.get getPos = new GetField0.get();
      getPos.__arg0 = testBody;
      getPos.Run();
      Tuple<float, float> p = getPos.__res.Value;

      //get velocity
      GetField3.get getVel = new GetField3.get();
      getVel.__arg0 = testBody;
      getVel.Run();
      Tuple<float, float> v = getVel.__res.Value;

      //get acceleration
      GetField5.get getAcc = new GetField5.get();
      getAcc.__arg0 = testBody;
      getAcc.Run();
      Tuple<float, float> a = getAcc.__res.Value;

      //set position
      __opComma<float, float> newPos = new __opComma<float, float>();
      newPos.__arg0 = 5f;
      newPos.__arg1 = 2.5f;
      SetField0.set setPos = new SetField0.set();
      setPos.__arg0 = testBody;
      setPos.__arg1 = newPos;
      setPos.Run();
      updatedBody = setPos.__res.Value;

      //set velocity
      __opComma<float, float> newVel = new __opComma<float, float>();
      newVel.__arg0 = 2f;
      newVel.__arg1 = 20f;
      SetField2.set setVel = new SetField2.set();
      setVel.__arg0 = updatedBody;
      setVel.__arg1 = newVel;
      setVel.Run();
      updatedBody = setVel.__res.Value;

      //set velocity
      __opComma<float, float> newAcc = new __opComma<float, float>();
      newAcc.__arg0 = 0.1f;
      newAcc.__arg1 = 10f;
      SetField5.set setAcc = new SetField5.set();
      setAcc.__arg0 = updatedBody;
      setAcc.__arg1 = newAcc;
      setAcc.Run();
      updatedBody = setAcc.__res.Value;
    }

    static void TestUpdater()
    {
      Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> testBody = Test.Tester.MakeRandomBody();
      Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedBody;

      RecordUpdater5.update bodyUpdater = new RecordUpdater5.update();
      bodyUpdater.__arg0 = testBody;
      bodyUpdater.__arg1 = 1f;
      bodyUpdater.Run();
      updatedBody = bodyUpdater.__res.Value;
    }

    static double TestWorldUpdater(int bodyCount, int iterations)
    {
      Stopwatch watch = new Stopwatch();
      __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> testWorld = new __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>();
      __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> updatedWorld = new __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>();
      __opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> testBodies = (__opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>)Test.Tester.MakeRandomBodies(bodyCount);
      testWorld.__arg0 = testBodies;
      testWorld.__arg1 = new unit();
      watch.Start();
      for (int i = 0; i < iterations; i++)
      {
        RecordUpdater7.update updateWorld = new RecordUpdater7.update();
        updateWorld.__arg0 = testWorld;
        updateWorld.__arg1 = 1f;
        updateWorld.Run();
        testWorld = (__opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>)updateWorld.__res.Value;
      }     
      watch.Stop();
      return watch.ElapsedMilliseconds / 1000.0 / iterations;
    }

    static void RunTest(int[] entityNumberArray, int iterations, string fileName, bool printToConsole = false)
    {
      string report = "Entity number,Average update\n";
      for (int i = 0; i < entityNumberArray.Length; i++)
      {
        System.Console.WriteLine("Running test with " + entityNumberArray[i] + " physical bodies");
        double elapsedTime = TestWorldUpdater(entityNumberArray[i], iterations);
        report += entityNumberArray[i] + "," + elapsedTime + "\n";
      }
      if (printToConsole)
        System.Console.Write(report);
      Directory.CreateDirectory("Report");
      File.WriteAllText(Path.Combine(new string[]{ "Report", fileName }), report);
    }

    static void Main(string[] args)
    {
      //{ Position = (2f,3f); Velocity = (1f,1f); Acceleration = (0.5f,0.5f) }
      //TestSettersAndGetters();
      //TestUpdater();
      //TestWorldUpdater(1000);
      int[] entityCounts = new int[]
        {
          100,
          250,
          500,
          750,
          1000
        };
      RunTest(entityCounts, 10000, "evaluation_traversal.csv");
    }
  }
}
