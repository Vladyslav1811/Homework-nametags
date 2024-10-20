using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write your tag number(1-7)");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int daynumber))
        {
            if (daynumber >= 1 && daynumber <= 7)
            {
                string dayName = "";
                switch (daynumber)
                {
                    case 1:
                        dayName = "Понеділок";
                        break;
                    case 2:
                        dayName = "Вівторок";
                        break;
                    case 3:
                        dayName = "Середа";
                        break;
                    case 4:
                        dayName = "Четвер";
                        break;
                    case 5:
                        dayName = "П'ятниця";
                        break;
                    case 6:
                        dayName = "Субота";
                        break;
                    case 7:
                        dayName = "Неділя";
                        break;
                }
                Console.WriteLine($"\r\nName of the day of the week: {dayName}");
            }
            else
            {
                Console.WriteLine("ERROR write correct number berwen 1 - 7.");
            }
        }
        else 
        {
            Console.WriteLine("it's not a number ERROR");
        }    
    }
}
