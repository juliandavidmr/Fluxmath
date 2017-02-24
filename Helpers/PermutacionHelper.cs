using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers {
  public class PermutacionHelper {

    /**
     * <summary>Teorema 1.3 Cuarta edición: Obtiene el numero de permutaciones de n objetos distintos, tomando r a la vez</summary>
     * <param name="n">Numero de objetos</param>
     * <param name="r">Cantidad a tomar a la vez</param>
     */
    public static long nDistint(long n, long r) {
      return permutar(n) / permutar(n - r);
    }

    // TODO: Corregir error de desbordarmiento de pila (error Stackoverflow)
    public static long permutar(long n) {
      if (n == 1) {
        return n;
      }
      return n * permutar(n - 1);
    }
  }
}
