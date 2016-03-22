using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int numero, int rangoInferior, int rangoSuperior)
        {
            if (numero >= rangoInferior && numero <= rangoSuperior)
                return true;
            return false;
        }
    }
}
