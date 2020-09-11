namespace XML.Core.Funcionalidad.Matematica
{
    public struct ObtenerPorcentaje
    {
        public static decimal Calcular(string valordecimal, int porcentaje)
        {
            decimal valor = TruncarDecimales.Obtener2(valordecimal);
            return TruncarDecimales.Obtener2(valor * porcentaje / 100);
        }
    }
}
