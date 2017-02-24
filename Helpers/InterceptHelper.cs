using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpers {
  public class InterceptHelper {

    public static List<string> intercept(List<string> a, List<string> b) {
      return a.Intersect(b).ToList<string>();
    }

    public static string[] toList(string input) {
      return input.Split(',');
    }
  }
}
