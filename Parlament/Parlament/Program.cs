using Parlament;

Forr fore = new Forr();
Whille whille = new Whille();
Serial2 serial = new Serial2();

string start = "e";
string choise = "1";

switch (start)
{
    case "s":

        switch (choise)
        {
            case "for":
                fore.fo_16();
                break;
            case "while":
                whille.wh_16();
                break;
            case "serial":
                serial.se_20();
                break;
            default:
                Console.WriteLine("Некорректный ввод");
                break;
        }

        goto case "e";
    case "e":
        Console.WriteLine("");
        Console.WriteLine("Введите:\tFor\tWhile\tSerial");
        choise = Console.ReadLine();
        goto case "s";
    default:
        break;

}
