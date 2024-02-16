using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is my Money Scanner!");
        Console.WriteLine("Enter a valid coins or bills:");
        double denomination = Convert.ToInt32(Console.ReadLine());

        string name = GetName(denomination);

        Console.WriteLine($"{name}.");
    }

    static string GetName(double denomination)
    {
        string name = "";

        switch (denomination)
        {
            case .01:
                name = "No Person is found in Php. .01";
                break;
            case .05:
                name = "No Person is found in Php. .05";
                break;
            case .25:
                name = "No Person is found in Php. .25";
                break;
            case 1:
                name = "Jose Rizal is found in Php. 1";
                break;
            case 5:
                name = "Emilio Aguinaldo is found in Php. 5";
                break;
            case 10:
                name = "Andres Bonifacio & Appolinario Mabini is found in Php. 10";
                break;
            case 20:
                name = "Manuel Quezon is found in Php. 20";
                break;
            case 50:
                name = "Sergio Osmena is found in Php. 50";
                break;
            case 100:
                name = "Manuel Roxas is found in Php. 100";
                break;
            case 200:
                name = "Diosdado Macapagal is found in Php. 200";
                break;
            case 500:
                name = "Benigno Aquino Sr. & Corazon Aquino is found in Php. 500";
                break;
            case 1000:
                name = "Jose Abad Santos, Josefa Escoda, & Vicente Lim is found in Php. 1000";
                break;
            default:
                name = "Invalid Demomination";
                break;
        }

            return name;
    }
}