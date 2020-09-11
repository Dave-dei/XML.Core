using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML.Core.Funcionalidad
{
    public struct BuscarValueXML
    {
        private static string Default(XAttribute item) => item == null ? "" : item.Value;
        private static string Default(XElement item) => item == null ? "" : item.Value;

        public static string Buscar(XElement item, string atributo, Sistema.Nivel nivel = Sistema.Nivel.Atributo)
        {
            if (item == null)
                return "";

            string resultado = string.Empty;


            switch (nivel)
            {
                case Sistema.Nivel.Elemento:
                    if (item.HasElements)
                        resultado = Default(item.Elements().FirstOrDefault(i => ValidarItemXML.Validar(i.Name.LocalName, atributo)));
                    break;
                case Sistema.Nivel.Atributo:
                    if (item.HasAttributes)
                        resultado = Default(item.Attributes().FirstOrDefault(i => ValidarItemXML.Validar(i.Name.LocalName, atributo)));
                    break;
                case Sistema.Nivel.ElementroAtributo:
                    resultado = Default(item.Elements()?.Attributes()?.FirstOrDefault(i => ValidarItemXML.Validar(i.Name.LocalName, atributo)));
                    break;
                case Sistema.Nivel.Raiz:
                    resultado = ValidarItemXML.Validar(item.Name.LocalName, atributo) ? item.Value : "";
                    break;
                default:
                    resultado = string.Empty;
                    break;
            }

            return resultado;
        }
        public static string Buscar(List<XElement> elemento, string atributo)
        {
            string value = "";
            if (elemento?.Elements().Any() == true)
            {
                var items = elemento.Elements().ToArray();
                for (int i = 0; i < items.Count(); i++)
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        break;

                    value = Buscar(items[i], atributo, Sistema.Nivel.Raiz);
                }
            }

            return value;
        }


    }
}
