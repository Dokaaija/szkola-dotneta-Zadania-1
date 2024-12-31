using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace szkola_dotneta
{
    class Program
    {
        public Worker Pracownik1 = new Worker();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MenuGlowne();

            
        }

        public void MenuGlowne() 
        {  
            Console.WriteLine("Witamy w Menu");
            Console.WriteLine("1 - Zadanie nr 1 , 2 zadanie - 2 , 3- zadanie 3, 4 zadanie... wiesz juz jakie ;-; jest tu tylko 5 zadan itd");
            switch (OdpowiedzUzytkownika(Console.ReadLine()))
            {
                case 1:
                    Pracownik();
                    break;
                case 2:
                    ZmianaKolejnosci();
                    break;
                case 3:
                    ObliczPrzekatna();
                    break;
                case 4:
                    Console.WriteLine("Teoretycznie wiecej typow jest u pracownika, wiec to rowniez zadanie 4");
                    MenuGlowne();
                    break;
                case 5:
                    Pracownik();
                    break;
                case 999:
                    Console.WriteLine("Nieprawidlowy Format/Zakres Odpowiedzi");
                    break;
                default:
                    Console.WriteLine("Niewlasciwa odpowiedz");
                    MenuGlowne();
                    break;
            }
        }
        public void Pracownik() 
        {
            Console.WriteLine("Witamy w zadaniu 1 i 5");
            Console.WriteLine("1- Stworz przykladowego Pracownika, 2- Stworz Wlasnego Pracownika,3- Przestaw Pracownika, 4- Wyjscie");
            switch (OdpowiedzUzytkownika(Console.ReadLine()))
            {
                case 1:
                    StworzPracownika();
                    break;
                case 2:
                    Start();
                    break;
                case 3:
                    PrzedstawSie();
                    break;
                case 4:
                    MenuGlowne();
                    break;
                default:
                    Console.WriteLine("Niewlasciwa odpowiedz");
                    MenuGlowne();
                    break;
            }
        }
        public void PrzedstawSie()
        {
            Console.WriteLine("Witaj: Moje imie to" + Pracownik1.GetImie());
            Console.WriteLine("Moje Nazwisko:" + Pracownik1.GetNazwisko());
            Console.WriteLine("Mam lat: " + Pracownik1.GetWiek());
            Console.WriteLine("Moja Plec: " + Pracownik1.GetPlec());
            Console.WriteLine("Moj Pesel: " + Pracownik1.GetPesel());
            Console.WriteLine("Moj NrPracowniczy to:" + Pracownik1.GetNrPracownika());
            Pracownik();
        }

        public void StworzPracownika() 
        {
            
            Pracownik1.SetImie("Dawid");
            Pracownik1.SetNazwisko("Kowalski");
            Pracownik1.SetWiek(28);
            Pracownik1.SetPlec('K');
            Pracownik1.SetPesel("76262662612");
            Pracownik1.SetNrPracownika("A-1923 , B-84329");
            Pracownik();
        }
        public void Start() 
        {
            Console.WriteLine("Witaj, Wprowadz Dane pracownika");
            
                Console.WriteLine("Co Chcesz Zrobic?");
                Console.WriteLine("1-Imie, 2- Nazwisko, 3- Wiek, 4- Plec, 5- Pesel, 6 -NrPracownika, 7 - Wyjscie do menu");
               
                switch (OdpowiedzUzytkownika(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Wpisz imie");
                        Pracownik1.SetImie(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Wpisz Nazwisko");
                        Pracownik1.SetNazwisko(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Wpisz Wiek");
                        int odp2 = OdpowiedzUzytkownika(Console.ReadLine());
                        if (odp2 != 999)
                        {
                            Pracownik1.SetWiek(odp2);
                        }
                        else 
                        {
                            Console.WriteLine("Wpisano niepoprawny format, Upewnij sie ze wpisujesz Liczbe");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Wpisz plec wedlug kodu K lub M ");
                        char odp3 = Console.ReadKey().KeyChar;
                        SprawdzPlec(odp3);
                        break;
                    case 5:
                        Console.WriteLine("Prosze wpisac pesel");
                        string Odp4 = Console.ReadLine();
                        SprawdzPesel(Odp4);
                        break;
                    case 6:
                        Console.WriteLine("Wpisz numer pracownika");
                        string Odp5 = Console.ReadLine();
                        Pracownik1.SetNrPracownika(Odp5);
                        break;
                    case 7:
                        MenuGlowne();
                        break;
                    case 999:
                    Console.WriteLine("Niepoprawnie sformatowane Dane, Wpisz jeszcze raz");
                    Start();
                    break;
                default:
                    Console.WriteLine("Wystapil Nieprzewidzany Problem :(");
                    Start();
                    break;
                }



            
            
        
        }
        public int OdpowiedzUzytkownika(string Odp) 
        {
            if (int.TryParse(Odp, out int liczba))
            {
                return liczba;
            }
            return 999;                    
        }
        
        public void SprawdzPlec(char OdpPlec) 
        {
            if (OdpPlec == 'k' || OdpPlec == 'm')
            {
                Pracownik1.SetPlec(OdpPlec);
            }
            else
            {
                Console.WriteLine("Przepraszam ale to prosty program, nie obslugujemy wszystkich 70 płci ani ich wariacji/odmian");
            }
            MenuGlowne();
        }
        public void SprawdzPesel(string pesel) 
        {
            Regex regex = new Regex("^[0-9]{11}$");
            if (!regex.IsMatch(pesel))
            {
                Pracownik1.SetPesel(pesel);
            }
        }



        public void ZmianaKolejnosci() 
        {
            char[] litery = { 'A', 'B', 'C' };

           
            var odwróconeLitery = litery.Reverse();

            
            Console.WriteLine("Litery w odwrotnej kolejności:");
            foreach (char litera in odwróconeLitery)
            {
                Console.WriteLine(litera);
            }
            MenuGlowne();

        }
        public void ObliczPrzekatna() 
        {
            Console.WriteLine("Podaj szerokość prostokąta:");
            double szerokosc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość prostokąta:");
            double dlugosc = Convert.ToDouble(Console.ReadLine());
                        
            double przekatna = Math.Sqrt(Math.Pow(szerokosc, 2) + Math.Pow(dlugosc, 2));

            Console.WriteLine($"Długość przekątnej prostokąta wynosi: {przekatna}");
            MenuGlowne();
        }
        

        


    }
}
