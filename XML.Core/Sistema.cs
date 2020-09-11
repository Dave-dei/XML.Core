namespace XML.Core
{
    public struct Sistema
    {
        public enum Nodo
        {
            Comprobante = 1,
            Concepto = 2,
            Emisor = 3,
            Receptor = 4,
            Timbre = 5,
            Traslado = 6,
            Nomina = 7,
            Periodo = 8,
            TotalSPT = 9,
            ServiciosPlataformasTecnologicas = 10,
            RetencionesSPT = 11,
            VisualStudio = 12,
            Nuget = 13,
            Config = 14,
            xsd = 15
        }

        public enum Nivel
        {
            Elemento = 1,
            Atributo = 2,
            ElementroAtributo = 3,
            Raiz = 4
        }
    }
}
