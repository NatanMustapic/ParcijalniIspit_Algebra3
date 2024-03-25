using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Podaci
    {
        public List<Klase.Banka> ListaBanki { get; set; }
        public List<Klase.Klijent> ListaKlijenata { get; set; }

        public Podaci()
        {
            // Inicijalizacija liste banaka
            ListaBanki = new List<Klase.Banka>
            {
                new Klase.Banka { Simbol = "PBZ", Naziv = "Privredna Banka Zagreb" },
                new Klase.Banka { Simbol = "OTP", Naziv = "OTP Banka" },
                new Klase.Banka { Simbol = "ERSTE", Naziv = " Erste&Steiermärkische Bank" }
            };

            // Inicijalizacija liste klijenata
            ListaKlijenata = new List<Klase.Klijent>
            {
                new Klase.Klijent { ImePrezime = "Nikola Tesla", Stanje = 50000, Banka = "PBZ" },
                new Klase.Klijent { ImePrezime = "Ruđer Bošković", Stanje = 1000000, Banka = "PBZ" },
                new Klase.Klijent { ImePrezime = "Marin Getaldić", Stanje = 2000000, Banka = "OTP" },
                new Klase.Klijent { ImePrezime = "Ivan Supek", Stanje = 30000, Banka = "OTP" },
                new Klase.Klijent { ImePrezime = "Miroslav Krleža", Stanje = 1500000, Banka = "OTP" },
                new Klase.Klijent { ImePrezime = "Vesna Parun", Stanje = 200000, Banka = "ERSTE" },
                new Klase.Klijent { ImePrezime = "Ivo Andrić", Stanje = 80000, Banka = "ERSTE" },
                new Klase.Klijent { ImePrezime = "Dubravko Horvatić", Stanje = 5000000, Banka = "ERSTE" },
                new Klase.Klijent { ImePrezime = "Antun Gustav Matoš", Stanje = 700, Banka = "PBZ" },
                new Klase.Klijent { ImePrezime = "Marija Jurić Zagorka", Stanje = 200000, Banka = "PBZ" }
            };
        }
    }
}
