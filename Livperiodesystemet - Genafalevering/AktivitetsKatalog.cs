using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livperiodesystemet___Genafalevering
{
    class AktivitetsKatalog 
    {

        public string AktivitetsNavn { get; set; }
        public string Lokation { get; set; }
        public List<Aktivitet> Aktiviteter { get; set; }
        public Dictionary<int, Aktivitet> AktiviteterDic { get; set; }


        public AktivitetsKatalog(string aktivitetsNavn, string lokation)
        {
            Lokation = lokation;
            AktivitetsNavn = aktivitetsNavn;
            Aktiviteter = new List<Aktivitet>();
            AktiviteterDic = new Dictionary<int, Aktivitet>();
        }

        public override string ToString()
        {
            int i = 0;
            while (i == 1) ;

            foreach (Aktivitet aktivitet in Aktiviteter)
            {
                Console.WriteLine($"id : {aktivitet.Id}, {aktivitet.MinAlder} {aktivitet.MaxAlder}, {aktivitet.StartTidspunkt}, {aktivitet.SlutTidspunkt}");
                i++;
            }

            return $"Aktivitetsnavn:{AktivitetsNavn}, lokation:{Lokation}";
        }

        public void PrintAktiviteter()
        {

            foreach (Aktivitet aktivitet in Aktiviteter)
            {
                Console.WriteLine($"{AktivitetsNavn}, {Lokation}, {aktivitet.Id}, {aktivitet.MinAlder}  {aktivitet.MaxAlder}  {aktivitet.StartTidspunkt}  {aktivitet.SlutTidspunkt}");
                Console.WriteLine("___________________________");
                Console.WriteLine("___________________________");
            }

        }

        public void AddAktivitet()
        {

            try
            {


                Console.Clear();
                Console.WriteLine("id");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("NavnId");
                var NavnId = Console.ReadLine();
                Console.WriteLine("MinimumsAlder");
                var MinAlder = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("MaximumsAlder");
                var MaxAlder = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("StartTidspunkt");
                var startTidspunkt = DateTime.Parse(Console.ReadLine());


                Console.WriteLine("SlutTidspunkt");
                var slutTidspunkt = DateTime.Parse(Console.ReadLine());

                if (MinAlder > MaxAlder)
                {
                    throw new ArgumentException();
                }


                try
                {
                    if (startTidspunkt > slutTidspunkt)
                    {
                        throw new ArgumentException();
                    }

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("StartTidspunkt kan ikke være efter sluttidspunkt, prøv igen");
                }

                Console.WriteLine($"Din aktivitet er nu blevet tilføjet og fået tildelt nummeret {Aktiviteter.Count}");



                Aktivitet NyAktivitet = new Aktivitet(Id, MinAlder, MaxAlder, NavnId, startTidspunkt, slutTidspunkt);
                Aktiviteter.Add(NyAktivitet);




            }
            catch (ArgumentException)
            {
                Console.WriteLine("Fejl! minimums alderen kan ikke være højere end maksimums alderen.");
            }


        }

        public void DeleteAktivitet(int Id)
        {
            var SletAktivitet = Aktiviteter.Single(aktivitet => aktivitet.Id == Id);
            Aktiviteter.Remove(SletAktivitet);
        }

        #region Directionary Methods

        public void DeleteAktivitetDic(int Id)
        {
            AktiviteterDic.Remove(Id);
        }

        public void AddAktivitetDic(Aktivitet aktivitet)
        {
            AktiviteterDic.Add(aktivitet.Id, aktivitet);
        }

        #endregion

        public void UpdateAktivitet(int Id)
        {


            try
            {
                var aktivitet = Aktiviteter.FirstOrDefault(a => a.Id == Id);
                if (aktivitet == null)
                {
                    Console.WriteLine("Aktivitet ikke fundet");
                }
                else
                {
                    Console.WriteLine($"du har valgt {Id}, vælg det nye ID");
                    aktivitet.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("vælg ny minimums alder");
                    aktivitet.MinAlder = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("vælg ny maksimums alder");
                    aktivitet.MaxAlder = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Vælg ny dateTime");
                    aktivitet.StartTidspunkt = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("vælg ny DateTime");
                    aktivitet.SlutTidspunkt = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"Aktivitet nummer {Id}, er hermed opdateret");






                    try
                    {
                        if (aktivitet.StartTidspunkt > aktivitet.SlutTidspunkt)
                        {
                            throw new ArgumentException();
                        }

                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("StartTidspunkt kan ikke være efter sluttidspunkt, prøv igen");
                    }

                    try
                    {
                        if (aktivitet.MinAlder > aktivitet.MaxAlder)
                        {
                            throw new ArgumentException();
                        }

                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Min.Alder kan ikke være højere end max alder.");
                    }


                }
            }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine("Venligst kun indsæt datoen i følgende format : DD-MM-YY-HH");
                Console.WriteLine("Tast 5 for at vende tilbage");


            }




        }


        public void VisMatchendeAkitivteter(string searchPhrase)
        {
            var matchendeAktiviteter = Aktiviteter.Where(p => p._navnId.Contains(searchPhrase)).ToList();
            foreach (Aktivitet aktivitet in matchendeAktiviteter)
            {
                PrintAktiviteter();
            }

        }

        public void brugerMenu()
        {
            Console.WriteLine("Tast 1 for at opdatere en aktivitet");
            Console.WriteLine("______________________________________");
            Console.WriteLine("Tast 2 for at søge efter en aktivitet");
            Console.WriteLine();
        }


















    }
}
            