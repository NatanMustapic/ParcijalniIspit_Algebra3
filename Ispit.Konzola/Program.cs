using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            Podaci podaci = new Podaci();
            

            // Grupiranje milijunaša po banci
            var GrupirajPremaBanci = from k in podaci.ListaKlijenata
                                     where k.Stanje >= 1000000
                                     group k.ImePrezime by k.Banka into g
                                     select new GrupiraniMilijunasi
                                     {
                                         Banka = g.Key,
                                         Milijunasi = g.ToList()
                                     };

            Console.WriteLine("Grupiranje milijunaša po banci:");
            foreach (var grupa in GrupirajPremaBanci)
            {
                Console.Write($"{grupa.Banka}: ");
                foreach (var milijunas in grupa.Milijunasi)
                {
                    Console.Write($" {milijunas}");
                }
                Console.Write("\n");
            }


            // Lista milijunaša
            var IzvjestajMilijunasa = from k in podaci.ListaKlijenata
                                      join b in podaci.ListaBanki on k.Banka equals b.Simbol
                                      where k.Stanje >= 1000000
                                      select new { ImePrezime = k.ImePrezime, Banka = b.Naziv };

            Console.WriteLine("\nIspis milijunaša i banke u kojoj se nalazi:");
            foreach (var milijunas in IzvjestajMilijunasa)
            {
                Console.WriteLine($"{milijunas.ImePrezime} je u {milijunas.Banka}");
            }


            Console.ReadKey();
        }
    }
}
