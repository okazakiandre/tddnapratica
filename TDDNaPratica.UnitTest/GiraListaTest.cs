using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TDDNaPratica.App;

namespace TDDNaPratica.UnitTest
{
    [TestClass]
    public class GiraListaTest
    {
        [TestMethod]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe4Itens()
        {
            var lista = new List<int> { 10, 15, 20, 30 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(4, nova.Count);
            Assert.AreEqual(15, nova[0]);
            Assert.AreEqual(10, nova[3]);
        }

        [TestMethod]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe3Itens()
        {
            var lista = new List<int> { 12, 15, 25 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(3, nova.Count);
            Assert.AreEqual(15, nova[0]);
            Assert.AreEqual(12, nova[2]);
        }

        [TestMethod]
        public void DeveriaMoverOPrimeiroItemParaOFinalNumaListaDe5Itens()
        {
            var lista = new List<int> { 1, 22, 333, 4444, 55555 };
            var gira = new GiraLista();

            var nova = gira.Girar(lista);

            Assert.AreEqual(5, nova.Count);
            Assert.AreEqual(22, nova[0]);
            Assert.AreEqual(1, nova[4]);
        }
    }
}
