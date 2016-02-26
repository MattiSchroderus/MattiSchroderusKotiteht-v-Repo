using System;

namespace Koostaminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle("Toyota", "Purkki");
            Console.WriteLine(mycar.ToString());

            mycar.RemoveTyres();
            Console.WriteLine(mycar.ToString());

            mycar.AddTyre(new Tyre("Nokia", "Hakkapeliitta", "195/65R15"));
            Console.WriteLine(mycar.ToString());
            Console.ReadLine();
        }
    }
}
