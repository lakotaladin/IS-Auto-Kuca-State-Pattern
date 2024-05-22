using System;

namespace UpravljanjeInventaromVozila
{
    //Primenio sam State pattern na upravljanje inventarom vozila, mozemo koristiti stanja da bismo modelirali razlicite faze kroz koje vozilo prolazi u sistemu.
    // Na primer, mozemo imati sledeca stanja:
   // Available(Dostupno) : Vozilo je dostupno za prodaju.
   // Sold(Prodato): Vozilo je prodato kupcu.
   // InService(Na servisu): Vozilo je trenutno na servisu.
   // Kao primer, napravio sam klasu za kontekst koja ce predstaviti vozilo, kao i stanja za razlicite faze u kojima se vozilo moze nalaziti.
   // Implementirao sam metode za prelazak iz jednog stanja u drugo.


    class Program
    {
        static void Main(string[] args)
        {
            var vozilo = new Vozilo(new DostupnoStanje());
            vozilo.Prodaj();
            vozilo.PosaljiNaServis();
            vozilo.OznaciDostupno();
            Console.ReadLine();
        }
    }
}

