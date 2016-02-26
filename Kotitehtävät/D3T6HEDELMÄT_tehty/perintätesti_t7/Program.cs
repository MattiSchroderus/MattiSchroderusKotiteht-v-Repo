using System;

namespace perintätesti_t7
{
    class Program
    {
        static void Main(string[] args)
        {
            SitrusHedelmat sitruuna = new SitrusHedelmat(1, "Keltainen", 5);
            SitrusHedelmat appelsiini = new SitrusHedelmat(4, "Oranssi", 2);
            MuutHedelmat banaani = new MuutHedelmat(5, "Keltainen", 7);

            Console.WriteLine(
                "\n  SITRUUNA\n"+
                "\n  Makeus: " + sitruuna.Makeus+
                "\n  Vari: " + sitruuna.Vari+
                "\n  happamuus: " + sitruuna.Happamuus + "\n\n");

            Console.WriteLine(
                "\n  APPELSIINI\n" +
                "\n  Makeus: " + appelsiini.Makeus +
                "\n  Vari: " + appelsiini.Vari +
                "\n  happamuus: " + appelsiini.Happamuus + "\n\n");

            Console.WriteLine(
                "\n  BANAANI\n" +
                "\n  Makeus: " + banaani.Makeus +
                "\n  Vari: " + banaani.Vari +
                "\n  Pehmeys: " + banaani.Pehmeys + "\n\n");
        }
    }
}
