namespace Record4
{
  using Internals;
  using Tuple;
  using List;

  //RecordField "PhysicalBodies" List[PhysicalBodies] EmptyRecord
  public class cons
  {
    public List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __arg0;
    public Unit __arg1;
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
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> x = __arg0;
            Unit xs = __arg1;
            __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __tmp0 = new __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>();
            __tmp0.__arg0 = x;
            __tmp0.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp0;
            break;
          }
        default:
          break;
      }
    }
  }
}

//GetField WorldType "PhysicalBodies"
namespace GetField6
{
  using Internals;
  using Tuple;
  using List;

  public class get
  {
    public Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __arg0;
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
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> x = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            Unit xs = default(Unit);
            if (!(__arg0 is __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>))
            {
              goto default;
            }
            __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __tmp0 = (__opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            __res.HasValue = true;
            __res.Value = x;
            break;
          }
        default:
          break;
      }
    }
  }
}

//SetField WorldType "PhysicalBodies"
namespace SetField6
{
  using Internals;
  using Tuple;
  using List;

  public class set
  {
    public Tuple<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __arg0;
    public List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> __arg1;
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
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> x = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);
            Unit xs = default(Unit);
            List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>> v = default(List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>);

            if (!(__arg0 is __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>))
            {
              goto default;
            }
            __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __tmp0 = (__opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>)__arg0;
            x = __tmp0.__arg0;
            xs = __tmp0.__arg1;
            v = __arg1;
            __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit> __tmp1 = new __opComma<List<Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Tuple<Tuple<float, float>, Unit>>>>, Unit>();
            __tmp1.__arg0 = v;
            __tmp1.__arg1 = xs;
            __res.HasValue = true;
            __res.Value = __tmp1;
            break;
          }
        default:
          break;
      }
    }
  }
}