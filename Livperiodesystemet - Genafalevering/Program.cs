using System;

namespace Livperiodesystemet___Genafalevering
{
    class Program
    {
        static void Main(string[] args)
        {

            AktivitetsKatalog katalog1 = new AktivitetsKatalog("Badminton", "Næstved");

            var aktivitet1 = new Aktivitet(1, 9, 12, "Badminton 1", new DateTime(2022, 08, 14, 9, 00, 00), new DateTime(2022, 08, 14, 11, 00, 00));
            var aktivitet2 = new Aktivitet(2, 6, 14, "Badminton 2", new DateTime(2022, 08, 14, 12, 00, 00), new DateTime(2022, 08, 14, 15, 00, 00));
            var aktivitet3 = new Aktivitet(3, 7, 15, "Badminton 3", new DateTime(2022, 08, 14, 17, 00, 00), new DateTime(2022, 08, 21, 17, 00, 00));


            Console.WriteLine(katalog1);
            Console.WriteLine(aktivitet1._id);
            Console.WriteLine(aktivitet2.Id);


            Console.WriteLine();

            Console.WriteLine("LivperiodeSystemet");
            Console.WriteLine("");
            Console.WriteLine("1 for add");
            Console.WriteLine("2 for update");
            Console.WriteLine("3 for search");


            var UserInput = Console.ReadLine();

            while (true)
            {


                switch (UserInput)
                {
                    case "1":

                        Console.Clear();
                        katalog1.AddAktivitet();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Vælg et nummer fra menuen for at opdatere din pizza");
                        Console.WriteLine();
                        katalog1.PrintAktiviteter();
                        int nummer = Convert.ToInt32(Console.ReadLine());
                        katalog1.UpdateAktivitet(nummer);

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Søg efter en aktivitet via. navn");
                        Console.WriteLine();
                        var searchPhrase = Console.ReadLine();

                        katalog1.VisMatchendeAkitivteter(searchPhrase);


                        break;



                }

                UserInput = Console.ReadLine();









            }
        }
    }
}
