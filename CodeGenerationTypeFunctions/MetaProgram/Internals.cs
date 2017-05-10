using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace MetaCnvInternals
{
  public struct __MetaCnvResult<T> { public T Value; public bool HasValue; }
  public class unit
  {
    public string __name = "()";

    public override string ToString()
    {
      return __name;
    }
  }
}
