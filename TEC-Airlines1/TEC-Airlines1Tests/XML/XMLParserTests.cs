using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEC_Airlines1.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_Airlines1.XML.Tests
{
    [TestClass()]
    public class XMLParserTests
    {
        [TestMethod()]
        public void readVuelosTest()
        {
            XMLParser xml = new XMLParser();
            bool assert = xml.readVuelos();

            Assert.IsTrue(assert == true);
        }

        [TestMethod()]
        public void readUsuariosTest()
        {
            XMLParser xml = new XMLParser();
            bool assert = xml.readUsuarios();

            Assert.IsTrue(assert == true);
        }

        [TestMethod()]
        public void readPromocionesTest()
        {
            XMLParser xml = new XMLParser();
            bool assert = xml.readPromociones();

            Assert.IsTrue(assert == true);
        }

        [TestMethod()]
        public void writeVueloTest()
        {
            XMLParser xml = new XMLParser();
            bool assert = xml.writeVuelo("SJO", "Amsterdam", "false", "06/07/2017", "19:00", "1:00", "economica", "$600", "AirBus A380", "Nuevo");

            Assert.IsTrue(assert == true);
        }

        [TestMethod()]
        public void writeUsuarioTest()
        {
            XMLParser xml = new XMLParser();
            bool assert = xml.writeUsuario("Jose", "Badilla", "Umaña", "201271708", "josebaduma@gmail.com", "estudiante", "86481845", "josbad", "1234abc");

            Assert.IsTrue(assert == true);
        }

        [TestMethod()]
        public void writePromocionTest()
        {
            XMLParser xml = new XMLParser();
            bool assert = xml.writePromocion("Kolbi", "kolbi.cr", "xxxxxxx");

            Assert.IsTrue(assert == true);
        }
    }
}