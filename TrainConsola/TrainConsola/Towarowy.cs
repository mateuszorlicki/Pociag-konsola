using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainConsola
{
    class Towarowy : Wagon
    {
        private string ladunek;

        public Towarowy(string model, int masa, string ladunek)
        {
            this.model = model;
            this.masa = masa;
            this.ladunek = ladunek;
        }

        public override string Informacje()
        {
            return "Wagon osobowy: model: " + model + ", waga: " + masa + ", ladunek: " + ladunek;
        }
    }
}
