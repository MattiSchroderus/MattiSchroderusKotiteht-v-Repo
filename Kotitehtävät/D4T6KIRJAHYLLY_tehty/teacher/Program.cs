using System;

namespace Tavarat
{
    class program
    {
        static void Main(string[] args)
        {           
            Disk levy1 = new Disk();
            levy1.Levynnimi = "jonkinLevynnimi1";
            levy1.Artisti = "Artisti1";
            levy1.Kplmaara = 11;
            levy1.Vuosiluku = 1990;
            Console.WriteLine(levy1.ToString());
          
            Bluray levy2 = new Bluray();
            levy2.Levynnimi = "blurayLevynnimi2";
            levy2.Artisti = "Artisti2";
            levy2.Kplmaara = 9;
            levy2.Vuosiluku =2013;
            levy2.Tarkkuus = "1920x1080";
            Console.WriteLine(levy2.ToString());
           
            Dvd levy3 = new Dvd();
            levy3.Levynnimi = "dvdLevynnimi3";
            levy3.Artisti = "Artisti";
            levy3.Kplmaara = 23;
            levy3.Vuosiluku = 1998;
            levy3.Legitness = "Ei piratoitu";
            Console.WriteLine(levy3.ToString());   
        }
    }
}
