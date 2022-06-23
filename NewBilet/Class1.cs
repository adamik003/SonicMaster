using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBilet
{
    internal class Bilet
    {
        Dane DaneBiletu = new Dane { };
        //public string UpdateImie_i_Nazwisko(string Imie, string Nazwisko)
        //{
        //    DaneBiletu.Imie_i_Nazwisko = Imie + " " + Nazwisko;
        //}

        //public string UpdateKierunek(string Kierunek)
        //{
        //    DaneBiletu.Kierunek = Kierunek;
        //}

        //public string UpdateData(string Data)
        //{
        //    DaneBiletu.Data = Data;
        //}
        //public int UpdateIdKierunku(string Kierunek, string Data)
        //{
        //    DaneBiletu.Data = Data;
        //}
        void DodajDane()
        {
            
        }

        public struct Dane
        {
            public string Imie_i_Nazwisko;
            public string Kierunek;
            public string Data;
            public int IdStatku;
            public int Sniadanie;
            public int Obiad;
            public int Kolacja;
            public int Basen;
            public int VIP;
        }
    }
}
