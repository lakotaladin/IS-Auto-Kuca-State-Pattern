using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    public class ProdatoStanje : Stanje
    {

        public override void ObradiDostupno()
        {
            Console.WriteLine("Prodato vozilo ne može biti označeno kao dostupno.");
        }

        public override void ObradiProdato()
        {
            Console.WriteLine("Vozilo je već prodato.");
        }

        public override void ObradiNaServisu()
        {
            Console.WriteLine("Prodato vozilo ne može biti poslato na servis.");
        }
    }
}
