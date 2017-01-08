using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainConsola
{
    class Pociag : IPoprawnyPociag, IUzupelnijSklad
    {
        private List<Wagon> wagony = new List<Wagon>();
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();

        public bool MozeJechac()
        {
            int w = 0, l = 0;

            foreach (var element in wagony)
            {
                w += element.ReturnMasa();
            }

            foreach (var element in lokomotywy)
            {
                l += element.ReturnMasa();
            }

            if (l >= w) return true;
            return false;
        }

        public void DodajOsobowy(int masa, string model, string rodzaj)
        {
            wagony.Add(new Osobowy(model, masa, rodzaj));
        }

        public void DodajTowarowy(int masa, string model, string ladunek)
        {
            wagony.Add(new Towarowy(model, masa, ladunek));
        }

        public void DodajLokomotywe(int masa, string model)
        {
            lokomotywy.Add(new Lokomotywa(model, masa));
        }

        public string Informacje()
        {
            string opis = "Sklad pociagu:\n";

            foreach (var element in lokomotywy)
            {
                opis += element.Informacje();
                opis += "\n";
            }

            foreach (var element in wagony)
            {
                opis += element.Informacje();
                opis += "\n";
            }
            return opis;
        }
    }
}
