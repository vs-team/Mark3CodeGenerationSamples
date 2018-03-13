using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ElementUpdater float
namespace ElementUpdater0
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public float __arg0;
    public float __arg1;
    public __MetaCnvResult<float> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<float>();
      __res.Value = default(float);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            float v = default(float);
            float dt = default(float);
            v = __arg0;
            dt = __arg1;
            __res.HasValue = true;
            __res.Value = v;
            break;
          }
        default:
          break;
      }
    }
  }
}

//ElementUpdater Tuple[float,float]
namespace ElementUpdater1
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<float, float> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            float x = default(float);
            float xs = default(float);
            float dt = default(float);
            float x1 = default(float);
            float xs1 = default(float);
            if (!(__arg0 is __opComma<float, float>))
            {
              goto default;
            }
            __opComma<float, float> __tmp0 = (__opComma<float, float>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            dt = __arg1;
            ElementUpdater0.update __tmp1 = new ElementUpdater0.update();
            __tmp1.__arg0 = x;
            __tmp1.__arg1 = dt;
            __tmp1.Run();
            if (!(__tmp1.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<float> __tmp2 = __tmp1.__res;
            x1 = __tmp2.Value;
            ElementUpdater0.update __tmp3 = new ElementUpdater0.update();
            __tmp3.__arg0 = xs;
            __tmp3.__arg1 = dt;
            __tmp3.Run();
            if (!(__tmp3.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<float> __tmp4 = __tmp3.__res;
            xs1 = __tmp4.Value;
            __opComma<float, float> __tmp5 = new __opComma<float, float>();
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

//FieldUpdater PhysicalBodyType "Position"
namespace FieldUpdater0
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> field = default(Tuple<float, float>);
            Tuple<float, float> field1 = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            GetField0.get __tmp0 = new GetField0.get();
            __tmp0.__arg0 = rec;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            field = __tmp1.Value;
            ElementUpdater1.update __tmp2 = new ElementUpdater1.update();
            __tmp2.__arg0 = field;
            __tmp2.__arg1 = dt;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp3 = __tmp2.__res;
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

//FieldUpdater PhysicalBodyType "Velocity"
namespace FieldUpdater1
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> field = default(Tuple<float, float>);
            Tuple<float, float> field1 = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            GetField3.get __tmp0 = new GetField3.get();
            __tmp0.__arg0 = rec;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            field = __tmp1.Value;
            ElementUpdater1.update __tmp2 = new ElementUpdater1.update();
            __tmp2.__arg0 = field;
            __tmp2.__arg1 = dt;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp3 = __tmp2.__res;
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

//FieldUpdater PhysicalBodyType "Acceleration"
namespace FieldUpdater2
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> field = default(Tuple<float, float>);
            Tuple<float, float> field1 = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            GetField5.get __tmp0 = new GetField5.get();
            __tmp0.__arg0 = rec;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            field = __tmp1.Value;
            ElementUpdater1.update __tmp2 = new ElementUpdater1.update();
            __tmp2.__arg0 = field;
            __tmp2.__arg1 = dt;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp3 = __tmp2.__res;
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

//PositionRule
namespace FieldUpdater3
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> body = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            float xp = default(float);
            float xp1 = default(float);
            float yp = default(float);
            float yp1 = default(float);
            float xv = default(float);
            float yv = default(float);
            body = __arg0;
            dt = __arg1;
            GetField0.get __tmp0 = new GetField0.get();
            __tmp0.__arg0 = body;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            Tuple<float, float> __tmp2 = __tmp1.Value;
            if(!(__tmp2 is __opComma<float, float>))
            {
              goto default;
            }
            __opComma<float, float> __tmp3 = (__opComma<float, float>)__tmp2;
            xp = __tmp3.__arg0;
            yp = __tmp3.__arg1;
            GetField3.get __tmp4 = new GetField3.get();
            __tmp4.__arg0 = body;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp5 = __tmp4.__res;
            Tuple<float, float> __tmp6 = __tmp5.Value;
            if (!(__tmp6 is __opComma<float, float>))
            {
              goto default;
            }
            __opComma<float, float> __tmp7 = (__opComma<float, float>)__tmp6;
            xv = __tmp7.__arg0;
            yv = __tmp7.__arg1;
            xp1 = xp + xv * dt;
            yp1 = yp + yv * dt;
            __opComma<float, float> __tmp8 = new __opComma<float, float>();
            __tmp8.__arg0 = xp1;
            __tmp8.__arg1 = yp1;
            __res.HasValue = true;
            __res.Value = __tmp8;
            break;
          }
        default:
          break;
      }
    }
  }
}

//VelocityRule
namespace FieldUpdater4
{
  using Internals;
  using Tuple;
  using List;

  public class update
  {
    public Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> __arg0;
    public float __arg1;
    public __MetaCnvResult<Tuple<float, float>> __res;

    public void Run()
    {
      int __ruleIndex = 0;
      __res = new __MetaCnvResult<Tuple<float, float>>();
      __res.Value = default(Tuple<float, float>);
      __res.HasValue = false;

      switch (__ruleIndex)
      {
        case 0:
          {
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> body = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            float xv = default(float);
            float xv1 = default(float);
            float yv = default(float);
            float yv1 = default(float);
            float xa = default(float);
            float ya = default(float);
            body = __arg0;
            dt = __arg1;
            GetField3.get __tmp0 = new GetField3.get();
            __tmp0.__arg0 = body;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            Tuple<float, float> __tmp2 = __tmp1.Value;
            if (!(__tmp2 is __opComma<float, float>))
            {
              goto default;
            }
            __opComma<float, float> __tmp3 = (__opComma<float, float>)__tmp2;
            xv = __tmp3.__arg0;
            yv = __tmp3.__arg1;
            GetField5.get __tmp4 = new GetField5.get();
            __tmp4.__arg0 = body;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp5 = __tmp4.__res;
            Tuple<float, float> __tmp6 = __tmp5.Value;
            if (!(__tmp6 is __opComma<float, float>))
            {
              goto default;
            }
            __opComma<float, float> __tmp7 = (__opComma<float, float>)__tmp6;
            xa = __tmp7.__arg0;
            ya = __tmp7.__arg1;
            xv1 = xv + xa * dt;
            yv1 = yv + ya * dt;
            __opComma<float, float> __tmp8 = new __opComma<float, float>();
            __tmp8.__arg0 = xv1;
            __tmp8.__arg1 = yv1;
            __res.HasValue = true;
            __res.Value = __tmp8;
            break;
          }
        default:
          break;
      }
    }
  }
}

//NoUpdate PhysicalBodyType
namespace RecordUpdater0
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> r = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
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

//Update VelocityRule zero
namespace RecordUpdater1
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedRecord = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> v = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            FieldUpdater4.update __tmp0 = new FieldUpdater4.update();
            __tmp0.__arg0 = rec;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            v = __tmp1.Value;
            SetField2.set __tmp2 = new SetField2.set();
            __tmp2.__arg0 = rec;
            __tmp2.__arg1 = v;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp3 = __tmp2.__res;
            rec1 = __tmp3.Value;
            RecordUpdater0.update __tmp4 = new RecordUpdater0.update();
            __tmp4.__arg0 = rec1;
            __tmp4.__arg1 = dt;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp5 = __tmp4.__res;
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

//Update PositionRule velRule
namespace RecordUpdater2
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedRecord = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> v = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            FieldUpdater3.update __tmp0 = new FieldUpdater3.update();
            __tmp0.__arg0 = rec;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            v = __tmp1.Value;
            SetField0.set __tmp2 = new SetField0.set();
            __tmp2.__arg0 = rec;
            __tmp2.__arg1 = v;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp3 = __tmp2.__res;
            rec1 = __tmp3.Value;
            RecordUpdater1.update __tmp4 = new RecordUpdater1.update();
            __tmp4.__arg0 = rec1;
            __tmp4.__arg1 = dt;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp5 = __tmp4.__res;
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

//Update accUpdate posUpdate
namespace RecordUpdater3
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedRecord = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> v = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            FieldUpdater2.update __tmp0 = new FieldUpdater2.update();
            __tmp0.__arg0 = rec;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            v = __tmp1.Value;
            SetField5.set __tmp2 = new SetField5.set();
            __tmp2.__arg0 = rec;
            __tmp2.__arg1 = v;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp3 = __tmp2.__res;
            rec1 = __tmp3.Value;
            RecordUpdater2.update __tmp4 = new RecordUpdater2.update();
            __tmp4.__arg0 = rec1;
            __tmp4.__arg1 = dt;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp5 = __tmp4.__res;
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

//Update velUpdate accUpdate
namespace RecordUpdater4
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedRecord = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> v = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            FieldUpdater1.update __tmp0 = new FieldUpdater1.update();
            __tmp0.__arg0 = rec;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            v = __tmp1.Value;
            SetField2.set __tmp2 = new SetField2.set();
            __tmp2.__arg0 = rec;
            __tmp2.__arg1 = v;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp3 = __tmp2.__res;
            rec1 = __tmp3.Value;
            RecordUpdater3.update __tmp4 = new RecordUpdater3.update();
            __tmp4.__arg0 = rec1;
            __tmp4.__arg1 = dt;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp5 = __tmp4.__res;
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

//Update posUpdate velUpdate
namespace RecordUpdater5
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
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> rec1 = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>> updatedRecord = default(Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>);
            float dt = default(float);
            Tuple<float, float> v = default(Tuple<float, float>);
            rec = __arg0;
            dt = __arg1;
            FieldUpdater0.update __tmp0 = new FieldUpdater0.update();
            __tmp0.__arg0 = rec;
            __tmp0.__arg1 = dt;
            __tmp0.Run();
            if (!(__tmp0.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<float, float>> __tmp1 = __tmp0.__res;
            v = __tmp1.Value;
            SetField0.set __tmp2 = new SetField0.set();
            __tmp2.__arg0 = rec;
            __tmp2.__arg1 = v;
            __tmp2.Run();
            if (!(__tmp2.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp3 = __tmp2.__res;
            rec1 = __tmp3.Value;
            RecordUpdater4.update __tmp4 = new RecordUpdater4.update();
            __tmp4.__arg0 = rec1;
            __tmp4.__arg1 = dt;
            __tmp4.Run();
            if (!(__tmp4.__res.HasValue))
            {
              goto default;
            }
            __MetaCnvResult<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __tmp5 = __tmp4.__res;
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
