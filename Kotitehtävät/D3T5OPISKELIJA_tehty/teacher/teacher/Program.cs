using System;

namespace teacher
{
    class program
    {
        static void Main(string[] args)
        {
           

            // create a one Student object with parametric constuctor
            Student student1 = new Student("Teppo", "Tepponen", "k21§490", "Ykkoskujankatu 3c", "042 789 1234" );
            Console.WriteLine(student1.ToString());


            Student student2 = new Student("Seppo", "Sepponen", "h56350", "Kakkoskujankatu 3c", "042 567 1234");
            Console.WriteLine(student2.ToString());

            Student student3 = new Student("Keijo", "Keijonen", "h46246", "Kolmoskujankatu 3c", "042 123 1234");
            Console.WriteLine(student3.ToString());

            Student student4 = new Student("Teijo", "Teijonen", "k34634", "Neloskujankatu 3c", "042 234 1234");
            Console.WriteLine(student4.ToString());

            Student student5 = new Student("Taneli", "Kaneli", "i34643", "Vitoskujankatu 3c", "042 456 1234");
            Console.WriteLine(student5.ToString());

            Console.WriteLine("\n\n\n");

        }


    }
}
