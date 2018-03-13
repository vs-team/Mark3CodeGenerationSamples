//UpdateEntity BodyUpdater
namespace ElementUpdater2
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public float __arg1;
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> entity = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> entity1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            entity = __arg0;
            dt = __arg1;
            RecordUpdater5.update __tmp0 = new RecordUpdater5.update();
            __tmp0.__arg0 = entity;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp1 = __tmp0.__res;
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __tmp2 = __tmp1.Value;
            entity1 = __tmp2;
            __res.HasValue = true;
            __res.Value = entity1;
            break;
          }
        default:
          break;
      }
    }
  }
}

//UpdateList bodyUpdater
namespace ElementUpdater3
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __arg0;
    public float __arg1;
    public __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>>();
      __res.Value = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            float dt = default(float);
            if (!(__arg0 is nil<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>))
            {
              goto case 1;
            }
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp0 = (nil<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>)__arg0;
            nil<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp1 = new nil<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
            dt = __arg1;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        case 1:
          {
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> x = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> xs = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            float dt = default(float);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> x1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> xs1 = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            if (!(__arg0 is __opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>))
            {
              goto default;
            }
            __opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp0 = (__opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            dt = __arg1;
            ElementUpdater2.update __tmp1 = new ElementUpdater2.update();
            __tmp1.__arg0 = x;
            __tmp1.__arg1 = dt;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp2 = __tmp1.__res;
            x1 = __tmp2.Value;
            update __tmp3 = new update();
            __tmp3.__arg0 = xs;
            __tmp3.__arg1 = dt;
            __tmp3.Run();
            if (!(__tmp3.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>> __tmp4 = __tmp3.__res;
            xs1 = __tmp4.Value;
            __opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp5 = new __opColonColon<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>();
            __tmp5.__arg0 = x1;
            __tmp5.__arg1 = xs1;
            __res.HasValue = true;
            __res.Value = __tmp5;
            break;
          }
        default:
          break;
      }
    }
  }
}

//UpdateField listUpdater WorldType "PhysicalBodies"
namespace FieldUpdater5
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __arg0;
    public float __arg1;
    public __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>>();
      __res.Value = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> rec = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
            float dt = default(float);
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> field = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> field1 = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            rec = __arg0;
            dt = __arg1;
            GetField6.get __tmp0 = new GetField6.get();
            __tmp0.__arg0 = rec;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>> __tmp1 = __tmp0.__res;
            field = __tmp1.Value;
            ElementUpdater3.update __tmp2 = new ElementUpdater3.update();
            __tmp2.__arg0 = field;
            __tmp2.__arg1 = dt;
            __tmp2.Run();
            if(!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>> __tmp3 = __tmp2.__res;
            field1 = __tmp3.Value;
            __res.HasValue = true;
            __res.Value = field1;
            break;
          }
        default:
          break;
      }
    }
  }
}

//NoUpdate WorldType
namespace RecordUpdater6
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>>();
      __res.Value = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> r = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
            float dt = default(float);
            r = __arg0;
            dt = __arg1;
            __res.HasValue = true;
            __res.Value = r;
            break;
          }
        default:
          break;
      }
    }
  }
}

//Update fieldUpdater zero
namespace RecordUpdater7
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>>();
      __res.Value = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> rec = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
            Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> rec1 = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
            Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> updatedRecord = default(Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>);
            float dt = default(float);
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> v = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            rec = __arg0;
            dt = __arg1;
            FieldUpdater5.update __tmp0 = new FieldUpdater5.update();
            __tmp0.__arg0 = rec;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>> __tmp1 = __tmp0.__res;
            v = __tmp1.Value;
            SetField6.set __tmp2 = new SetField6.set();
            __tmp2.__arg0 = rec;
            __tmp2.__arg1 = v;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>> __tmp3 = __tmp2.__res;
            rec1 = __tmp3.Value;
            RecordUpdater6.update __tmp4 = new RecordUpdater6.update();
            __tmp4.__arg0 = rec1;
            __tmp4.__arg1 = dt;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>> __tmp5 = __tmp4.__res;
            updatedRecord = __tmp5.Value;
            __res.HasValue = true;
            __res.Value = updatedRecord;
            break;
          }
        default:
          break;
      }
    }
  }
}
