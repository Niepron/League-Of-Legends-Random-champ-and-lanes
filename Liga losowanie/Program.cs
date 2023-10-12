using HtmlAgilityPack;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Witaj w programie wyboru losowych lini i postaci do LOL'a!!!");
        Console.WriteLine("");
        Console.WriteLine("Aby losować wpisz 'losuj'");
        Console.WriteLine("");
        Console.WriteLine("Aby wyjść z programu wpisz 'exit'");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.Green;
        string opcja1=Console.ReadLine();
        while (true)
        {
            switch (opcja1)
            {


                case "losuj":
                case "Losuj":
                case "LOSUJ":
                {
                        int liczbagraczy = Iloscpostaci();
                        Console.Clear();
                        Console.WriteLine("Czy losować również postacie? ('tak','nie')");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string losowaniepostaciodpowiedz = Console.ReadLine();
                        while (true)
                        {
                            switch (losowaniepostaciodpowiedz)
                            { 
                                case "TAK":
                                case "tak":
                                case "Tak":
                                    {
                                        LosowanieLinIPostaci(liczbagraczy);
                                        break;
                                    }
                                case "Nie":
                                case "NIE":
                                case "nie":
                                    {
                                        LosowanieLin(liczbagraczy);
                                        break;
                                    }
                                default:
                                    {
                                            Console.WriteLine("Nie ma takiej opcji!");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(">");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            losowaniepostaciodpowiedz = Console.ReadLine();
                                        break;
                                    }
                            }
                        }
                    }
                case "exit":
                case "EXIT":
                case "Exit":
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                            Console.WriteLine("Nie ma takiej opcji!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(">");
                            Console.ForegroundColor = ConsoleColor.Green;
                            opcja1 = Console.ReadLine();
                        break;
                    }
            }
        }
    }
    static int Iloscpostaci()// Wpisywanie ilości postaci i sprawdzanie poprawności
    {
            int liczbagraczy;
            Console.Clear();
        while (true)
        {
            Console.WriteLine("Podaj liczbę graczy, którym trzeba wylosować linię (1-5): ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();

            if (int.TryParse(input, out liczbagraczy) && liczbagraczy >= 1 && liczbagraczy <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Podano niepoprawną liczbę. Proszę podać liczbę od 1 do 5.");
            }
        }
            return liczbagraczy;
    }

    static void LosowanieLinIPostaci(int liczbagraczy)  //Skryp losujący razem z postaciami 
    {
        Console.Clear();
        Random random = new Random();
        string[] linie = { "Top", "Jungle", "Mid", "Bot", "Sup" };
        string[] postacie = {"Aatrox", "Ahri", "Akali", "Akshan", "Alistar", "Amumu", "Anivia", "Annie","Aphelios","Ashe","Aurelion Sol","Azir","Bard",
        "Bel'veth", "Blitzcrank", "Brand", "Braum", "Briar", "Caltlyn","Camille","Cassiopeia","Cho'gath","Corki","Darius","Diana","Dr.Mundo","Draven","Ekko",
        "Elise","Evelynn","Ezreal","Fiddlesticks","Fiora","Fizz","Galio","Gankplank","Garen","Gnar","Gragas","Graves","Gwen","Hecarim","Heimerdinger","Illaoi",
        "Irelia","Ivern","Janna","Jarvan IV","Jax","Jayce","Jhin","Karthus","Kassadin","Katarina","Kayle","Kayn","Kennen","Kha'zix","Kindred","Kled","Kog'maw",
        "Leblanc","Lee Sin","Leona","Lillia","Lissandra","Lucian","Lulu","Lux","Malphite","Malzahar","Maokai","Master YI","Milio","Miss Frotune","Mordekaiser",
        "Morgana","Naafiri","Nami","Nasus","Nautilus","Nekko","Nidalle","Nilah","Nocturne","Nunu & Willump","Olaf","Orianna","Ornn","Pantheon","Poppy","Pyke",
        "Qiyana","Quinn","Rakan","Rammus","Rek'sai","Rell","Renata Glasc","Renekton","Rengar","Riven","Rumble","Ryze","Samira","Sejuani","Senna","Seraphine",
        "Sett","Shaco","Shen","Shyvana","Singed","Sion","Sivir","Skarner","Sona","Soraka","Swain","Sylas","Syndra","Tahm Kench","Taliyah","Talon","Taric",
        "Temmo <3","Thresh","Tristana","Trundle","Tryndamere","Twisted Fate","Twitch","Udyr","Urgot","Varus","Vayne","Veigar","Vel'koz","Vex","Vi","Viego",
        "Viktor","Vladimir","Volivear","Warwick","Wukong","Xayah","Xerath","Xin Zhao", "Yasuo","Yone","Yorick","Yuumi","Zac","Zed","Zeri","Ziggs","Zilean",
        "Zoe","Zyra"};


        List<string> dostepneLinie = new List<string>(linie);
        List<string> dostepnePostacie = new List<string>(postacie);
        int linia;
        for (int i = 0; i < liczbagraczy; i++)
        {
            if (dostepneLinie.Count > 0)
            {
                int indeks = random.Next(0, dostepneLinie.Count);
                int indeks2;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("gracz " + (i+1) + "  "+ dostepneLinie[indeks]);
                int zm1 = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Postacie:");
                while (zm1 < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    indeks2 = random.Next(0, dostepnePostacie.Count);
                    Console.WriteLine((zm1+1)+ " " + dostepnePostacie[indeks2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dostepnePostacie.RemoveAt(indeks2);
                    zm1++;
                }
                dostepneLinie.RemoveAt(indeks);
            }
        }
        Console.WriteLine("Czy losować ponownie? 'Tak' lub 'Nie' ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.Green;
        string odnowa1 = Console.ReadLine();

        while (true)
        {
            switch (odnowa1)
            {
                case "Tak":
                case "TAK":
                case "tak":
                    {
                        Main();
                        break;
                    }
                case "nie":
                case "NIE":
                case "Nie":
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Wpisz ponownie >");
                        Console.ForegroundColor = ConsoleColor.Green;
                        odnowa1 = Console.ReadLine();
                        break;
                    }
            }
        }
    }
    static void LosowanieLin(int liczbagraczy) //Skryp losujący bez postaci 
    {
        Console.Clear();
        Random random = new Random();
        string[] linie = { "Top", "Jungle", "Mid", "Bot", "Sup" };
        List<string> dostepneLinie = new List<string>(linie);
        int linia;
        for (int i = 0; i < liczbagraczy; i++)
        {
            if (dostepneLinie.Count > 0)
            {
                int indeks = random.Next(0, dostepneLinie.Count);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("gracz " + (i+1) + "  " + dostepneLinie[indeks]);
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                dostepneLinie.RemoveAt(indeks);
            }
        }
        Console.WriteLine("Czy losować ponownie?");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.Green;
        string odnowa2 = Console.ReadLine();
        while (true)
        {
            switch (odnowa2)
            {
                case "Tak":
                case "TAK":
                case "tak":
                    {
                        Main();
                        break;
                    }
                case "nie":
                case "NIE":
                case "Nie":
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Wpisz ponownie >");
                        Console.ForegroundColor = ConsoleColor.Green;
                        odnowa2 = Console.ReadLine();
                        break;
                    }
            }
        }
    }
}
