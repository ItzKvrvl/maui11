using System;

namespace ConsoleApp15
{
    public interface IDokument
    {
        string Tytul { get; }
        DateTime DataUtworzenia { get; }
        void Wyswietl();
    }

    public class Faktura : IDokument
    {
        public string Tytul { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public decimal Kwota { get; set; }

        public void Wyswietl()
        {
            Console.WriteLine("┌─────────────────────────────────┐");
            Console.WriteLine($"│ Tytuł: {Tytul,-23}");
            Console.WriteLine($"│ Data: {DataUtworzenia:yyyy–MM–dd}     ");
            Console.WriteLine($"│ Kwota: {Kwota:C}    ");
            Console.WriteLine("└─────────────────────────────────┘");
        }
    }

    public class Raport : IDokument
    {
        public string Tytul { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public string Autor { get; set; }

        public void Wyswietl()
        {
            Console.WriteLine("┌─────────────────────────────────┐");
            Console.WriteLine($"│ Tytuł: {Tytul,-23}");
            Console.WriteLine($"│ Data: {DataUtworzenia:yyyy–MM–dd}     ");
            Console.WriteLine($"│ Autor: {Autor:C}    ");
            Console.WriteLine("└─────────────────────────────────┘");
        }
    }
    public class Email : IDokument
    {
        public string Tytul { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public string Nadawca { get; set; }

        public void Wyswietl()
        {
            Console.WriteLine("┌─────────────────────────────────┐");
            Console.WriteLine($"│ Tytul: {Tytul,-23}");
            Console.WriteLine($"│ Data: {DataUtworzenia:yyyy–MM–dd}     ");
            Console.WriteLine($"│ Od: {Nadawca:C}    ");
            Console.WriteLine("└─────────────────────────────────┘");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n==== Zadanie 1 ====\n");
            Console.WriteLine("!Zadanie w kodzie jako komentarz!");
            /*1 Po dodaniu loggera trzeba dodac kolejny if
            2 Kod jest trudny w utrzymaniu bo przy kazdej zmianie trzeba recznie wprowadzac zmiany w wielu miejscach
            3 Bedzie mozna wywolac jedna motode
            4
            Logger
            {
                void Loguj(wiadomosc)
            }
            Pochodna{
            public void Loguj(wiadomosc)
            {
                console.writeLine("$plik {wiadomosc})
            }}*/

            Console.WriteLine("\n==== Zadanie 2 ====\n");

            List<IDokument> dokumenty = new List<IDokument>
            {
             new Faktura {Tytul="Faktura Vat", DataUtworzenia = DateTime.Parse("2025-10-22"), Kwota = 41499 },
             new Raport {Tytul="Raport", DataUtworzenia = DateTime.Parse("2025-12-11"), Autor = "Xyz" },
             new Email {Tytul="Email", DataUtworzenia = DateTime.Parse("2025-05-01"), Nadawca = "Wlaziu@gmail.com" }
            };

            foreach (IDokument dokument in dokumenty)
            {
                dokument.Wyswietl();
            }

            Console.WriteLine("\nPo sortowaniu: ----------------");

            var posortowane = dokumenty.OrderBy(d => d.DataUtworzenia);
            foreach (var dokument in posortowane)
            {
                dokument.Wyswietl();
            }

        }
    }
}



