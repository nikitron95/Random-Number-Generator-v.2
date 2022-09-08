

Random Zahl = new Random();

int versuche = 1;
int Nutzer = 0;
int random;
string validator = "y";
bool repeat = false;
string nochmal = "";

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Willkommen beim RandomNumberGenerator!");
Console.WriteLine("Viel Glück beim raten!!!");
Console.ForegroundColor = ConsoleColor.White;




random = Zahl.Next(1, 101);
    Console.WriteLine(random);

do
{
    do
    {
        try
        {
            Console.WriteLine("Gib eine Zahl zwischen 1 und 100 ein: ");
            Nutzer = Convert.ToInt32(Console.ReadLine());
            if (Nutzer > 100 || Nutzer < 1)
            {
                throw new Exception();
            }
            else
            {
                repeat = false;
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ungültige Eingabe");
            Console.ForegroundColor = ConsoleColor.White;
            repeat = true;
        }

    } while (repeat == true);

    if (random > Nutzer)
    {
        Console.WriteLine("Die Gesuchte Zahl ist grösser!");

    }
    else if (random < Nutzer)
    {
        Console.WriteLine("Die Gesuschte Zahl ist kleiner");
    }
    else if (random == Nutzer)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Glückwunsch die Eratene Zahl ist " + random);
        Console.ForegroundColor = ConsoleColor.White;
        do
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Try once more?(y/n)");
                Console.ForegroundColor = ConsoleColor.White;
                nochmal = Console.ReadLine();
                if (nochmal == "n" || nochmal == "y")
                {
                    repeat = false;
                }

                if (nochmal != "n" && nochmal != "y")
                {
                    throw new Exception();
                }



            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("falsche Eingabe");
                Console.ForegroundColor = ConsoleColor.White;
                repeat = true;
            }

        } while (repeat);
    }
} while (nochmal == "y" || random != Nutzer);
//Prüft ob die eingabe ungleich ist.


