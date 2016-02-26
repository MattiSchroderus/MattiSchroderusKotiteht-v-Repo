using System;

namespace perintätesti_t7
{
    class Hedelmat
    {
        public int Makeus { get; set; } // 1-5
        public string Vari { get; set; } // pun, sin, vihr, jne.

        public Hedelmat(int makeus, string vari)
        {
            Makeus = makeus;
            Vari = vari;
        }
    }
}
