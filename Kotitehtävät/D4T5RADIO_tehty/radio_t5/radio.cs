using System;

namespace radio_t5
{
    class Radio
    {
        public float Taajuus { get; set; }
        public int AanenVoimakkuus { get; set; }

        public Radio(float taajuus, int aanenVoimakkuus)
        {
            Taajuus = taajuus;
            AanenVoimakkuus = aanenVoimakkuus;           
        }


    }
}
