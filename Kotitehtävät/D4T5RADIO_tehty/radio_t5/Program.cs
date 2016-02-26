using System;

namespace radio_t5
{
    class Program
    {

       
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            Radio radio = new Radio(2300, 4);

            Console.WriteLine("\n  1. volume + \n  2. volume -\n  3. frequency +\n  4. frequency -\n  5 radio off ");
            do
            {
                caseSwitch = int.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:

                        radio.AanenVoimakkuus++;

                        Console.WriteLine("  Aanenvoimakkuus: " + radio.AanenVoimakkuus);
                        break;

                    case 2:
                        radio.AanenVoimakkuus--;

                        Console.WriteLine("  Aanenvoimakkuus: " + radio.AanenVoimakkuus);
                        break;
                    case 3:
                        radio.Taajuus++;

                        Console.WriteLine("  Taajuus: " + radio.Taajuus);
                        break;
                    case 4:
                        radio.Taajuus--;

                        Console.WriteLine("  Taajuus: " + radio.Taajuus);
                        break;
                    case 5:
                        caseSwitch = 0;
                        break;
                    default:
                        caseSwitch = 0;                     
                        break;
                }
            } while (caseSwitch != 0);


        }
    }
}
