using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    public class NaServisuStanje : Stanje
    {
        public override void ObradiDostupno()
        {
            Console.WriteLine("Vozilo se vraća sa servisa i dostupno je za prodaju.");
            this._kontekst?.PrelazakNa(new DostupnoStanje());
        }

        public override void ObradiProdato()
        {
            Console.WriteLine("Vozilo ne može biti prodato dok je na servisu.");
        }

        public override void ObradiNaServisu()
        {
            Console.WriteLine("Vozilo je već na servisu.");
        }
    }
}
