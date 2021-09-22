using System;

namespace RandomNumber._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomnumber;
            Random randm = new Random();
            randomnumber = randm.Next(1, 101);
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string Titel = @"
████████╗██╗  ██╗███████╗     ██████╗ ██████╗ ██╗ ██████╗ ██╗███╗   ██╗ █████╗ ██╗         ███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗      ██████╗  █████╗ ███╗   ███╗███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔═══██╗██╔══██╗██║██╔════╝ ██║████╗  ██║██╔══██╗██║         ████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
   ██║   ███████║█████╗      ██║   ██║██████╔╝██║██║  ███╗██║██╔██╗ ██║███████║██║         ██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝    ██║  ███╗███████║██╔████╔██║█████╗  
   ██║   ██╔══██║██╔══╝      ██║   ██║██╔══██╗██║██║   ██║██║██║╚██╗██║██╔══██║██║         ██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
   ██║   ██║  ██║███████╗    ╚██████╔╝██║  ██║██║╚██████╔╝██║██║ ╚████║██║  ██║███████╗    ██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
   ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚═╝ ╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝    ╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                                                                                                                                         
";
                Console.WriteLine(Titel);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Ich denke mir eine Zahl aus zwischen 1 und 100. Finde die Zahl heraus: ");
            Console.WriteLine("----------------------------------------------------------------------");
            int versuche = 1;
            int notnumber = 2005;
                while (notnumber == 2005)

            try
            {
                int rnumber = Convert.ToInt32(Console.ReadLine());


                while (rnumber != randomnumber)
                {

                    while (rnumber < 1 || rnumber > 100)
                    {
                        Console.WriteLine("Bitte gib eine gültige Zahl ein!!");
                        rnumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("---------------------------------");
                    }

                    if (rnumber > randomnumber)
                    {
                        Console.WriteLine("Oh!, viel zu hoch, tippe eine neue Zahl ein");
                        Console.WriteLine("-------------------------------------------");
                    }

                    else if (rnumber < randomnumber)
                    {
                        Console.WriteLine("Viel zu tief!, versuche es weiter");
                        Console.WriteLine("---------------------------------");
                    }

                    versuche++;
                    rnumber = Convert.ToInt32(Console.ReadLine());
                }


                if (rnumber == randomnumber)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Gratulation, du hast es geschaft");
                    Console.WriteLine("Du hast " + versuche + " Versuche gebraucht.");
                }



            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe, bitte halte dich an die Vorschriften!");
                    continue;
            }
        }
    }
}
