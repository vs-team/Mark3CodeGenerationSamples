using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internals
{
  public struct __MetaCnvResult<T>
  {
    public T Value;
    public bool HasValue;
  }

  public interface Unit { }

  public class unit : Unit
  {
    public string __name = "()";

    public override string ToString()
    {
      return "()";
    }
  }
}

namespace Tuple
{
  using Internals;

  public interface Tuple<a, b> { }

  public class __opComma<a, b> : Tuple<a, b>
  {
    public string __name = ",";
    public a __arg0;
    public b __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }
}

namespace List
{
  using Internals;

  public interface List<a> { }

  public class nil<a> : List<a>
  {
    public string __name = "nil";

    public override string ToString()
    {
      return "(" + __name + ")";
    }
  }

  public class __opColonColon<a> : List<a>
  {
    public string __name = "::";
    public a __arg0;
    public List<a> __arg1;

    public override string ToString()
    {
      return "(" + __arg0 + " " + __name + " " + __arg1 + ")";
    }
  }
}
