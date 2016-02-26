using System;

namespace perintätesti_t7
{
    class SitrusHedelmat : Hedelmat
    {
        public int Happamuus { get; set; } // 4-9

        public SitrusHedelmat(int makeus, string vari, int happamuus) : base(makeus, vari)
        {
            Happamuus = happamuus;
        }
    }
}
