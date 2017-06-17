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
            XmlNode VuelosNodo = doc.SelectSingleNode("/root/Vuelos");
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
                String estado = node.Attributes.GetNamedItem("estado").Value;

                Console.WriteLine("origen = " + origen + "llegada = " + llegada + " escalado = " + escalado + " fSalida = " + fSalida + " hSalida = " + hSalida + " hEstimadaLlegada = " + hEstimadaLlegada + " clase = " + clase + " precio = " + precio + " modeloAvion = " + modeloAvion + "estado = " + estado);

            }
            return true;
        }

        public bool readUsuarios()
        {
            Console.WriteLine("Read XML Usuarios");
            XmlNode UsuariosNodo = doc.SelectSingleNode("/root/Usuarios");
            XmlNodeList usuarios = UsuariosNodo.SelectNodes("usuario");

            foreach (XmlNode node in usuarios)
            {
                String nombre = node.Attributes.GetNamedItem("nombre").Value;
                String apellido1 = node.Attributes.GetNamedItem("apellido1").Value;
                String apellido2 = node.Attributes.GetNamedItem("apellido2").Value;
                String carne = node.Attributes.GetNamedItem("carne").Value;
                String email = node.Attributes.GetNamedItem("email").Value;
                String ocupacion = node.Attributes.GetNamedItem("ocupacion").Value;
                String telefono = node.Attributes.GetNamedItem("telefono").Value;
                String usuario = node.Attributes.GetNamedItem("usuario").Value;
                String contraseña = node.Attributes.GetNamedItem("contraseña").Value;

                Console.WriteLine("Nombre = " + nombre + "Apellido = " + apellido1 + " " + apellido2 + " carne = " + carne + " email = " + email + " ocupacion = " + ocupacion + " telefono = " + telefono + " usuario = " + usuario + " contraseña = " + contraseña);

            }
            return true;
        }

        public bool readPromociones()
        {
            Console.WriteLine("Read XML Promociones");
            XmlNode UsuariosNodo = doc.SelectSingleNode("/root/Promociones");
            XmlNodeList usuarios = UsuariosNodo.SelectNodes("promocion");

            foreach (XmlNode node in usuarios)
            {
                String nombre = node.Attributes.GetNamedItem("nombre").Value;
                String enlace = node.Attributes.GetNamedItem("enlace").Value;
                String imagen = node.Attributes.GetNamedItem("imagen").Value;

                Console.WriteLine("Nombre = " + nombre + "Link = " + enlace + " imagen = " + imagen);

            }
            return true;
        }

        public bool writeVuelo( String origen,
                                String llegada,
                                String escalado,
                                String fSalida,
                                String hSalida,
                                String hEstimadaLlegada,
                                String clase,
                                String precio,
                                String modeloAvion,
                                String estado) {

            Console.WriteLine("Read XML Vuelos");
            XmlNode VuelosNodo = doc.SelectSingleNode("/root/Vuelos");
            XmlElement node = doc.CreateElement("vuelo");

            node.SetAttribute("origen", origen);
            node.SetAttribute("llegada", llegada);
            node.SetAttribute("escalado", escalado);
            node.SetAttribute("fSalida", fSalida);
            node.SetAttribute("hSalida", hSalida);
            node.SetAttribute("hEstimadaLlegada", hEstimadaLlegada);
            node.SetAttribute("clase", clase);
            node.SetAttribute("precio", precio);
            node.SetAttribute("modeloAvion", modeloAvion);
            node.SetAttribute("estado", estado);

            VuelosNodo.AppendChild(node);
            doc.Save("baseDatosXML.xml");

            return true;
        }

        public bool writeUsuario(String nombre,
                                String apellido1,
                                String apellido2,
                                String carne,
                                String email,
                                String ocupacion,
                                String telefono,
                                String usuario,
                                String contraseña)
        {

            Console.WriteLine("Write XML Usuarios");
            XmlNode VuelosNodo = doc.SelectSingleNode("/root/Usuarios");
            XmlElement node = doc.CreateElement("usuario");

            node.SetAttribute("nombre", nombre);
            node.SetAttribute("apellido1", apellido1);
            node.SetAttribute("apellido2", apellido2);
            node.SetAttribute("carne", carne);
            node.SetAttribute("email", email);
            node.SetAttribute("ocupacion", ocupacion);
            node.SetAttribute("telefono", telefono);
            node.SetAttribute("usuario", usuario);
            node.SetAttribute("contraseña", contraseña);

            VuelosNodo.AppendChild(node);
            doc.Save("baseDatosXML.xml");

            return true;
        }

        public bool writePromocion(String nombre,
                                String enlace,
                                String imagen) {

            Console.WriteLine("Write XML Promociones");
            XmlNode VuelosNodo = doc.SelectSingleNode("/root/Promociones");
            XmlElement node = doc.CreateElement("promocion");

            node.SetAttribute("nombre", nombre);
            node.SetAttribute("enlace", enlace);
            node.SetAttribute("imagen", imagen);

            VuelosNodo.AppendChild(node);
            doc.Save("baseDatosXML.xml");

            return true;
        }
    }
}