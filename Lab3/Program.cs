using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool VisaMeny = true;
            while (VisaMeny)
            {
                VisaMeny = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välj ett alternativ genom att skriva siffran och klicka enter");
            Console.WriteLine("(1) Gångertabell för 1 till 9");
            Console.WriteLine("(2) Kalkylator");
            Console.WriteLine("(3) Slump");
            Console.WriteLine("(4) Skapa en person");
            Console.WriteLine("(5) Avsluta");

            switch (Console.ReadLine())
            {
                case "1":
                    Tabell();
                    back();
                    return false;

                case "2":
                    Kalkylator();
                    back();
                    return false;

                case "3":
                    Slump();
                    back();
                    return false;

                case "4":
                    SkapaPerson();
                    back();
                    return false;

                case "5":
                    return false;

                default:
                    return true;
            }
        }

        public static void back()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Vill du återgå till menyn? Programmet kommer avslutas om du svarar nej. (JA/NEJ)");
            string svar = "ja";
            svar = Console.ReadLine();
            svar = svar.ToLower();

            if (svar == "ja")
            {
                MainMenu();
            }
        }

        static void Tabell()
        {

            int a, b;
            Console.WriteLine("\n");
            for (a = 1; a <= 9; a++)
            {
                Console.Write(a + "\t");
                for (b = 1; b <= 9; b++)
                {
                    Console.Write(a * b + ("\t"));
                }
                Console.WriteLine("\n");
            }
        }


        static void Kalkylator()
        {

            int i;
            int value;

            Console.WriteLine("Skriv in hur många tal du vill använda: ");
            value = int.Parse(Console.ReadLine());
            double[] tal = new double[value];
            Console.WriteLine("Skriv in dina tal, klicka på enter efter varje tal: ");
            for (i = 0; i < tal.Length; i++)
            {
                tal[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("\nDina tal är:");
            for (i = 0; i < tal.Length; i++)
            {
                Console.Write(" " + tal[i]);
            }
            double sum = 0;
            for (i = 0; i < tal.Length; i++)
            {
                sum += tal[i];
            }
            Console.WriteLine("\nSumman av dina tal är: " + sum);

            double medel = 0;
            for (i = 0; i < tal.Length; i++)
            {
                medel += tal[i] / tal.Length;
            }

            Console.WriteLine("Medelvärdet av dina tal är: " + medel);

            double min = tal[0];
            for (i = 0; i < tal.Length; i++)
            {
                if (tal[i] < min)
                {
                    min = tal[i];
                }
            }

            Console.WriteLine("Minsta värdet av dina tal är: " + min);

            //Börjar med [0] och sätter den som störst/minst
            //if tittar igenom om talet som för tillfället är störst/minst är större/mindre än nästa tal om det är sant byts det talet ut.
            double max = tal[0];
            for (i = 0; i < tal.Length; i++)
            {
                if (tal[i] > max)
                {
                    max = tal[i];
                }
            }
        }

        static void Slump()
        {
 
            Random ran = new Random();
           // int storlek;
            int i;

            Console.WriteLine("Hur många slumpade tal vill du ha?");
           // storlek = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            Console.WriteLine("\n");
            Console.WriteLine("Dina slumpade tal är följande: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(1, 100);
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\nDin tal i sorterad ordning ser ut sä här: ");
            Array.Sort(arr);

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        public static void SkapaPerson()
        {
            string svar = "nej";
            string eyecolor;
            string sex;
            DateTime age;
            hair har = new hair();

            List<Person> Personer = new List<Person>();

            while (true)
            {
                Console.WriteLine("Skriv in ögonfärg på personen: ");
                eyecolor = Console.ReadLine();
                Console.WriteLine("Skriv in könet på personen: ");
                sex = Console.ReadLine();
                Console.WriteLine("Skriv in när personen är född (YYYY/MM/DD): ");
                age = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in längden på personens hår i cm: ");
                har.hairlenght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in färgen på personens hår: ");
                har.haircolor = Console.ReadLine();
                Console.WriteLine();

                Personer.Add(new Person(eyecolor, sex, age, har));
                Console.WriteLine("Vill du lägga till en till person? (JA/NEJ)");
                svar = Console.ReadLine();
                svar = svar.ToLower();

                if (svar == "nej")
                {
                    break;
                }
            }

            foreach(var person in Personer)
            {
                Console.WriteLine("Ögonfärg: " +person.GetEyeColor());
                Console.WriteLine("Kön: " +person.sex);
                Console.WriteLine("Född: ");
                Console.WriteLine(age.ToString("yyyy-MM-dd"));
                Console.WriteLine("Hårlängd: " +person.har.hairlenght);
                Console.WriteLine("Hårfärg: " +person.har.haircolor);
            }
            }



            /* Console.WriteLine("Hur många personer vill du skapa?");
             int storlek;
             storlek = int.Parse(Console.ReadLine());
             Person[] NyPerson = new Person[storlek];
             Person Ny = new Person();
             Person.hair hår = new Person.hair(); */

            /*
            for (int i = 0; i < NyPerson.Length; i++)
            {
                Console.WriteLine("Skriv in ögonfärg på personen: ");
                string eyecolor = Console.ReadLine();
                Console.WriteLine("Skriv in könet på personen: ");
                Ny.sex = Console.ReadLine();
                Console.WriteLine("Skriv in när personen är född (YYYY/MM/DD): ");
                Ny.age = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in längden på personens hår i cm: ");
                hår.hairlenght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in färgen på personens hår: ");
                hår.haircolor = Console.ReadLine();
                Console.WriteLine();

               Console.WriteLine("Din person har följande egenskaper: \n");

                Console.WriteLine("Ögonfärg: " +eyecolor);
                Console.WriteLine("Kön: " + Ny.sex);
                Console.WriteLine("Född: ");
                Console.WriteLine(Ny.age.ToString("yyyy-MM-dd"));
                Console.WriteLine("Hårlängd: " + hår.hairlenght);
                Console.WriteLine("Hårfärg: " + hår.haircolor);
                */

        }
    }

