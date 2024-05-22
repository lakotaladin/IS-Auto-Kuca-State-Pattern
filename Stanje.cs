using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeInventaromVozila
{
    // Apstraktna klasa Stanje
    public abstract class Stanje
    {
        protected Vozilo? _kontekst;

        public void PostaviKontekst(Vozilo kontekst)
        {
            this._kontekst = kontekst;
        }

        public abstract void ObradiDostupno();
        public abstract void ObradiProdato();
        public abstract void ObradiNaServisu();
    }
}
