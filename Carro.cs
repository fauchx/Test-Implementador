using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Carro
    {

        public string id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string km { get; set; }

        public Carro()
        {
            this.id = "";
            this.marca = "";
            this.modelo = "";
            this.km = "";
        }

        public Carro(string id, string marca, string modelo, string km)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
        }
    }
}
