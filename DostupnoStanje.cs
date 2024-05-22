using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    // Konkretne klase stanja
    public class DostupnoStanje : Stanje
    {
        public override void ObradiDostupno()
        {
            Console.WriteLine("Vozilo je već dostupno.");
        }

        public override void ObradiProdato()
        {
            Console.WriteLine("Vozilo se prodaje.");
            this._kontekst.PrelazakNa(new ProdatoStanje());
        }

        public override void ObradiNaServisu()
        {
            Console.WriteLine("Vozilo ide na servis.");
            this._kontekst.PrelazakNa(new NaServisuStanje());
        }
    }
}
