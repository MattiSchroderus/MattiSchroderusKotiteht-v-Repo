using System;

namespace perintätesti_t7
{
    class MuutHedelmat : Hedelmat
    {
        public int Pehmeys { get; set; }

        public MuutHedelmat(int makeus, string vari, int pehmeys) : base(makeus, vari)
        {           
            Pehmeys = pehmeys;
        }
    }
}
