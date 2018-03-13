using Tuple;
using List;
using Internals;

namespace Test
{
  public static class Tester
  {
    static System.Random r = new System.Random();

    static float NextFloat(this System.Random r, double maxValue)
    {
      return (float)(r.NextDouble() * maxValue);
    }

    public static Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> MakeRandomBody()
    {
      const double maxValue = 50.0;
      __opComma<float, float> fst;
      unit unit;
      __opComma<Tuple<float, float>, Unit> acceleration = new __opComma<Tuple<float, float>, Unit>();
      fst = new __opComma<float, float>();
      unit = new unit();
      fst.__arg0 = r.NextFloat(maxValue);
      fst.__arg1 = r.NextFloat(maxValue);
      acceleration.__arg0 = fst;
      acceleration.__arg1 = unit;
      __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>> velocity = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>();
      fst = new __opComma<float, float>();
      fst.__arg0 = r.NextFloat(maxValue);
      fst.__arg1 = r.NextFloat(maxValue);
      velocity.__arg0 = fst;
      velocity.__arg1 = acceleration;
      __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> position = new __opComma<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>();
      fst = new __opComma<float, float>();
      fst.__arg0 = r.NextFloat(maxValue);
      fst.__arg1 = r.NextFloat(maxValue);
      position.__arg0 = fst;
      position.__arg1 = velocity;
      return position;
    }

    public static List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> MakeRandomBodies(int bodyCount)
    {
      List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> randomBodies = new nil<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
      for (int i = 0; i < bodyCount; i++)
      {
        var currentBodies = new __opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
        currentBodies.__arg0 = MakeRandomBody();
        currentBodies.__arg1 = randomBodies;
        randomBodies = currentBodies;
      }
      return randomBodies;
    }


  }
}
