using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    // Klasa Kontekst koja predstavlja vozilo
    public class Vozilo
    {
        private Stanje? _stanje = null;
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Godina { get; set; }
        public double Kilometraza { get; set; }
        public double Cena { get; set; }

        public Vozilo(Stanje stanje)
        {
            this.PrelazakNa(stanje);
        }

        public void PrelazakNa(Stanje stanje)
        {
            Console.WriteLine($"Vozilo: Prelazak na {stanje.GetType().Name}.");
            this._stanje = stanje;
            this._stanje.PostaviKontekst(this);
        }

        public void OznaciDostupno()
        {
            this._stanje?.ObradiDostupno();
        }

        public void Prodaj()
        {
            this._stanje?.ObradiProdato();
        }

        public void PosaljiNaServis()
        {
            this._stanje?.ObradiNaServisu();
        }
    }
}
