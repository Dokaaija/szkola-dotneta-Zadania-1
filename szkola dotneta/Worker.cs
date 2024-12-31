using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szkola_dotneta
{
    class Worker
    {
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int Wiek { get; set; }
        private char Plec { get; set; }
        private string Pesel { get; set; }
        private string NrPracownika { get; set; }

        public  void SetImie(string imie) 
        {
            this.Imie = imie;
        }
        public string GetImie()
        {
            return Imie;
        }
        public void SetNazwisko(string nazwisko)
        {
            this.Nazwisko = nazwisko;
        }
        public string GetNazwisko()
        {
            return Nazwisko;
        }
        public void SetWiek(int wiek)
        {
            this.Wiek = wiek;
        }
        public int GetWiek()
        {
            return Wiek;
        }
        public void SetPlec(char plec)
        {
            this.Plec = plec;
        }
        public char GetPlec()
        {
            return Plec;
        }
        public void SetPesel(string pesel)
        {
            this.Pesel = pesel;
        }
        public string GetPesel()
        {
            return Pesel;
        }
        public void SetNrPracownika(string nrPracownika)
        {
            this.NrPracownika = nrPracownika;
        }
        public string GetNrPracownika()
        {
            return NrPracownika;
        }

    }
}
