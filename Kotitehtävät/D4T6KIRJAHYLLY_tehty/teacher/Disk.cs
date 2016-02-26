using System;


namespace Tavarat
{
    
        class Disk
        {
            public string Levynnimi { get; set; }
            public string Artisti { get; set; }
            public int Kplmaara { get; set; }
            public int Vuosiluku { get; set; }

            public Disk()
            {

            }
            public Disk(string levynnimi, string artisti)
            {
                Levynnimi = levynnimi;
                Artisti = artisti;
            }

           
            public override string ToString()
            {
                return Levynnimi + " " + Artisti + " " + Kplmaara + " " + Vuosiluku;
            }
        }
}
