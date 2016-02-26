using System;
namespace Tavarat
{
    class Dvd : Disk
    {
        public string Legitness { get; set; }       
       
        public Dvd()
        {
        }

        public Dvd(string Levynnimi, string artisti, string legitness)
            : base(Levynnimi, artisti)
        {
            Legitness = legitness;
        }

   

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Legitness;
        }
    }
}
