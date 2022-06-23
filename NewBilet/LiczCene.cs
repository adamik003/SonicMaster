using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBilet
{
    internal class LiczCene
    {
        private string Podrozny;
        private string Gdzie;
        private string Kiedy;
        private string Nocleg;
        private int Dod1;
        private int Dod2;
        private int Dod3;
        private int Dod4;
        private int Dod5;
        private double CenaMin;
        private double CenaMax;

        public double CenaPodstawowa(string Imie, string Nazwisko, string Kierunek, string Data, string Pokoj, int Sniadanie, int Obiad, int Kolacja, int Basen, int VIP)
        {
            Podrozny = Imie + Nazwisko;
            Gdzie = Kierunek;
            Kiedy = Data;
            Nocleg = Pokoj;
            Dod1 = Sniadanie;
            Dod2 = Obiad;
            Dod3 = Kolacja;
            Dod4 = Basen;
            Dod5 = VIP;
            if(String.Compare(Kierunek, "Barcelona") == 0)
            {
                CenaMin = 100;
            }
        }

        public void CenaDoZaplaty(double amount)
        {
            
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
