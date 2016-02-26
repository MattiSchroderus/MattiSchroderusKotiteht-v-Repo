using System;

namespace Tavarat
{
    
    class Bluray : Disk
    {

        public string Tarkkuus;
        public Bluray() {

        }
        public Bluray(string levynnimi,string artisti, string tarkkuus) 
            : base(levynnimi, artisti)
        {
            Tarkkuus = tarkkuus;
        }
       
        public override string ToString()
        {
            return base.ToString() +" " +Tarkkuus;
        }

    }
}
