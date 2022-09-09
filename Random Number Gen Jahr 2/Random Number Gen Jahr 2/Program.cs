

Random Zahl = new Random();

int versuche = 1;
int Nutzer = 0;
int random;
string validator = "y";
bool repeat = false;
string nochmal = "";
int zähler = 1;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Willkommen beim RandomNumberGenerator!");
Console.WriteLine("Viel Glück beim raten!!!");
Console.ForegroundColor = ConsoleColor.White;




random = Zahl.Next(1, 101);
    

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
        zähler++;

    }
    else if (random < Nutzer)
    {
        Console.WriteLine("Die Gesuschte Zahl ist kleiner");
        zähler++;   
    }

    else if (random == Nutzer)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Glückwunsch die Erratene Zahl ist " + random);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Das war ihre Anzahl an versuche: " + zähler);

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



