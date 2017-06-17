using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace TEC_Airlines1.XML
{
    public class XMLParser
    {
        private XmlDocument doc;

        public XMLParser()
        {
            doc = new XmlDocument();
            doc.Load("baseDatosXML.xml");
        }

        public bool readVuelos()
        {
            Console.WriteLine("Read XML Vuelos");
            XmlNode VuelosNodo =
                doc.SelectSingleNode("/Vuelos");
            XmlNodeList vuelos = VuelosNodo.SelectNodes("vuelo");

            foreach (XmlNode node in vuelos)
            {
                String origen = node.Attributes.GetNamedItem("origen").Value;
                String llegada = node.Attributes.GetNamedItem("llegada").Value;
                String escalado = node.Attributes.GetNamedItem("escalado").Value;
                String fSalida = node.Attributes.GetNamedItem("fSalida").Value;
                String hSalida = node.Attributes.GetNamedItem("hSalida").Value;
                String hEstimadaLlegada = node.Attributes.GetNamedItem("hEstimadaLlegada").Value;
                String clase = node.Attributes.GetNamedItem("clase").Value;
                String precio = node.Attributes.GetNamedItem("precio").Value;
                String modeloAvion = node.Attributes.GetNamedItem("modeloAvion").Value;

                Console.WriteLine("origen = " + origen + "llegada = " + llegada + " escalado = " + escalado + " fSalida = " + fSalida + " hSalida = " + hSalida + " hEstimadaLlegada = " + hEstimadaLlegada + " clase = " + clase + " precio = " + precio + " modeloAvion = " + modeloAvion);

            }
            return true;
        }
    }
}