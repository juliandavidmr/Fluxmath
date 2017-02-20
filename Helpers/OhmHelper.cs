using System;
namespace Helpers {
  public class OhmHelper {

    /**
		 * <summary>Calcula la corriente</summary>
		 * <param name="resistencia">Resistencia</param>
		 * <param name="voltaje">Voltaje</param>
		*/
    public static float getI(float voltaje, float resistencia) {
      return voltaje * resistencia;
    }

    /**
		 * <summary>Calcula el voltaje</summary>
		 * <param name="corriente">Corriente</param>
		 * <param name="resistencia">Resistencia</param>
		*/
    public static float getV(float corriente, float resistencia) {
      return corriente / resistencia;
    }

    /**
		 * <summary>Calcula la corriente</summary>
		 * <param name="corriente">Corriente</param>
		 * <param name="voltaje">Voltaje</param>
		*/
    public static float getR(float voltaje, float corriente) {
      return voltaje / corriente;
    }
  }
}
