using HtmlAgilityPack;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()//podsatawowe menu 
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Witaj w programie wyboru losowych lini i postaci do LOL'a!!!");
        Console.WriteLine("");
        Console.WriteLine("Aby losować wpisz 'losuj'");
        Console.WriteLine("");
        Console.WriteLine("Aby wyjść z programu wpisz 'exit'");
        Console.WriteLine("");
        Console.WriteLine("Jeśli chcesz dodatkowe opcje wpisz 'MORE' :) ");
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
                case "MORE":
                case "more":
                case "More":
                    { 
                        drugiemenu();
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

    static void drugiemenu()//dodatkowe opcje 
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Żeby wrócić wpisz 'back'");
        Console.WriteLine("");
        Console.WriteLine("Aby wybrać losowe postacie oraz linie (lecz postacie będą posować tylko do danych liń)");
        Console.WriteLine("");
        Console.WriteLine("Żeby wybrać tę opcję wpisz 'losuj'");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.Green;
        string opcja4 = Console.ReadLine();
        while (true) {
            switch (opcja4)
            {
                case "back":
                case "BACK":
                case "Back":
                    {
                        Main();
                        break;
                    }
                case "losuj":
                case "Losuj":
                case "LOSUJ":
                    {
                        int liczbagraczy = Iloscpostaci();
                        LosowaniePostacidolin(liczbagraczy);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Green;
                        opcja4 = Console.ReadLine();
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
        for (int i = 0; i < liczbagraczy; i++)
        {
            if (dostepneLinie.Count > 0)
            {
                int indeks = random.Next(0, dostepneLinie.Count);
                Console.ForegroundColor = ConsoleColor.Magenta;
                int indeks2;
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
    static void LosowaniePostacidolin(int liczbagraczy) // skrypt losujący razem z postaciami ale pasującymi do danych liń
    { 
        string[] postacietop = { "Aatrox", "Akali", "Camille", "Cho'gath", "Darius", "Dr.Mundo", "Fiora", "Gankplank", "Garen", "Gnar","Gwen", "Illaoi", "Irelia",
        "Jax","Jayce","Kayle","Kennen","Kled","Malphite","Mordekaiser","Nasus","Olaf","Ornn","Pantheon","Poppy","Quinn","Renekton","Riven","Sett","Shen","Singed",
        "Sion","Tahm Kench","Temmo <3","Trundle","Tryndamere","Udyr","Urgot","Volivear","Wukong","Yasuo","Yone","Yorick"};
        string[] postaciejg = { "Amumu", "Bel'veth", "Briar", "Cho'gath", "Diana", "Dr.Mundo", "Ekko", "Elise", "Evelynn", "Fiddlesticks", "Gragas", "Graves", "Hecarim",
        "Ivern","Jarvan IV","Karthus","Kayn","Kha'zix","Kindred","Lee Sin","Lillia","Maokai","Master YI","Nidalle","Nocturne","Nunu & Willump","Rammus","Rek'sai","Rell",
        "Rengar","Sejuani","Shaco","Shen","Shyvana","Skarner","Taliyah","Udyr","Vi","Viego","Warwick","Xin Zhao","Zac"};
        string[] postaciemid = { "Ahri", "Akali", "Akshan", "Anivia","Annie", "Aurelion Sol", "Azir", "Cassiopeia", "Corki", "Diana", "Ekko", "Fizz", "Galio", "Irelia",
        "Kassadin","Katarina","Leblanc","Lissandra","Lucian","Lux","Malzahar","Naafiri","Nekko","Orianna","Qiyana","Rumble","Ryze","Sylas","Syndra","Talon","Twisted Fate",
        "Veigar","Vel'koz","Vex","Viktor","Vladimir","Yasuo","Yone","Zed","Zoe"};
        string[] postaciebot = { "Aphelios", "Ashe", "Caltlyn", "Draven", "Ezreal", "Jhin", "Karthus", "Kog'maw", "Lucian", "Miss Frotune", "Nilah", "Samira", "Sivir",
        "Tristana","Twitch","Varus","Vayne","Xayah","Zeri","Ziggs"};
        string[] postaciesup = { "Ahri", "Alistar", "Amumu", "Bard", "Blitzcrank", "Brand", "Braum", "Heimerdinger", "Janna", "Leona", "Lulu", "Lux", "Maokai","Milio",
        "Morgana","Nami","Nautilus","Nekko","Pantheon","Pyke","Rakan","Rell","Renata Glasc","Senna","Seraphine","Sona","Soraka","Swain","Taric","Thresh","Vel'koz",
        "Xerath","Yuumi","Zilean","Zyra"};
        string[] linie = { "Top", "Jungle", "Mid", "Bot", "Sup" };
        
        Console.Clear();
        Random random = new Random();
        List<string> dostepnetop = new List<string>(postacietop);
        List<string> dostepnejg = new List<string>(postaciejg);
        List<string> dostepnemid = new List<string>(postaciemid);
        List<string> dostepnebot = new List<string>(postaciebot);
        List<string> dostepnesup = new List<string>(postaciesup);
        List<string> dostepneLinie = new List<string>(linie);
        List<int> wylosowaneIndeksy = new List<int>();
        int indeks2;
        int zm1 = 0;
        int zm2 = 0;
        int zm3 = 0;
        int zm4 = 0;
        int zm5 = 0;
        for (int i = 0; i < liczbagraczy; i++)
        {
            int indeks;
            do
            {
                indeks = random.Next(0, dostepneLinie.Count);
            } 
            while (wylosowaneIndeksy.Contains(indeks));
            wylosowaneIndeksy.Add(indeks);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string wylosowanaLinia = dostepneLinie[indeks];
            Console.WriteLine("gracz " + (i + 1) + " " + wylosowanaLinia);

            if (indeks == 0)//top
            {
                while (zm1 < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    indeks2 = random.Next(0, dostepnetop.Count);
                    Console.WriteLine((zm1 + 1) + " " + dostepnetop[indeks2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dostepnetop.RemoveAt(indeks2);
                    zm1++;
                }

            }
            else if (indeks == 1) //jg
            {
                while (zm2 < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    indeks2 = random.Next(0, dostepnejg.Count);
                    Console.WriteLine((zm2 + 1) + " " + dostepnejg[indeks2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dostepnejg.RemoveAt(indeks2);
                    zm2++;
                }

            }
            else if (indeks == 2)//mid
            {
                while (zm3 < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    indeks2 = random.Next(0, dostepnemid.Count);
                    Console.WriteLine((zm3 + 1) + " " + dostepnemid[indeks2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dostepnemid.RemoveAt(indeks2);
                    zm3++;
                }

            }
            else if (indeks == 3)//bot
            {
                while (zm4 < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    indeks2 = random.Next(0, dostepnebot.Count);
                    Console.WriteLine((zm4 + 1) + " " + dostepnebot[indeks2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dostepnebot.RemoveAt(indeks2);
                    zm4++;
                }

            }
            else if (indeks == 4)//sup
            {
                while (zm5 < 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    indeks2 = random.Next(0, dostepnesup.Count);
                    Console.WriteLine((zm2 + 1) + " " + dostepnesup[indeks2]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    dostepnesup.RemoveAt(indeks2);
                    zm5++;
                }

            }
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        
        Console.WriteLine("Czy losować ponownie? 'Tak' lub 'Nie' ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.Green;
        string odnowa3 = Console.ReadLine();
        while (true)
        {
            switch (odnowa3)
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
                        odnowa3 = Console.ReadLine();
                        break;
                    }
            }
        }
    }
}
