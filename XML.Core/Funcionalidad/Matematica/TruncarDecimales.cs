using System;

namespace XML.Core.Funcionalidad.Matematica
{
    public struct TruncarDecimales
    {
        public static decimal Obtener2(string valor)
        {
            if (decimal.TryParse(valor, out decimal  valordecimal))
                return Convertir(valordecimal);
            else
                throw new Exception($"No se puede convertir a decimal el valor:{valor}");

        }
        public static decimal Obtener2(decimal valor) => Convertir(valor);

        private static decimal Convertir(decimal valordecimal) => Math.Truncate(valordecimal * 100) / 100;

    }
}
