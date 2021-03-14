using System;
using System.Collections.Generic;
using System.Text;

namespace TDDNaPratica.App
{
    public class GiraLista
    {
        public List<int> Girar(List<int> lista)
        {
            var itm0 = lista[0];
            var nova = new List<int>();
            lista.RemoveAt(0);
            nova.AddRange(lista);
            nova.Add(itm0);
            return nova;
        }
    }
}
