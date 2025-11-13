using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class MainClass
{
    public static void Main()
    {
        string ss = ("рандон кардон картон картоф");
        string[] sss = ss.Split(' ');
        string w = sss[new Random().Next(1, 4)]; ;
        string ans = "******";
        int f = 0;
        int totalScore = 0;
        int count = 0;
        int money = 0;
        while (f == 0)
        {   string secctor = FindSector();
            string hid = "";
            Console.WriteLine("Вращайте барабан");
            if (FindBank(secctor))
            {
                break;
            }
            else if (FindX2(secctor, totalScore))
            {
                continue;
            }
            else if (secctor == "+")
            {
                Console.WriteLine("Выберите номер любой буквы");

            }
            else if (secctor == "П")
            {
                Console.WriteLine("Приз или деньги?");
                string t = Console.ReadLine();
                if (t == "Приз")
                {
                    Console.WriteLine("Поздравляю, вы выиграли банан, гуляйте");
                    break;
                }
                else
                {
                    Console.WriteLine("Поздравляю, вы выиграли 100р, гуляйте");
                    break;
                }

            }
             

            else
            {
                int y = int.Parse(secctor);
                Console.WriteLine("Выпало баллов " + y);
                Console.WriteLine("угадывайте букву");
                string inp = Console.ReadLine();
                for (int i = 0; i < 5; i++)
                {

                    if ((inp[0] == w[i]) && (ans.Contains(inp) == false))
                    {
                        hid += inp;
                        totalScore += y;
                        count += 1;


                    }
                    else
                    {
                        hid += ans[i];
                        count = 0;


                    }
                    ans = hid;
                    Console.WriteLine(hid);
                    Console.WriteLine("Сумма баллов " + totalScore);

                }


            }
            if (count == 3)
            {

                FindPrise(money, count, )


            }
        }


    }
    static bool FindBank(string s)
    {   if (s == "Б")
        {
            Console.WriteLine("Банкрот");
            return true;
        }
        return false;
    }
    static bool FindX2(string s, int x)
    {
        if (s == "x2")
        {
            Console.WriteLine("Очки умножаются на 2");
            x *= 2;
            return true;
        }
        return false;
    }
    static bool FindPlus(string s, int x)
    {
        if (s == "x2")
        {
            Console.WriteLine("Очки умножаются на 2");
            x *= 2;
            return true;
        }
        return false;
    }
    static string FindSector()
    {
        string sectors = ("Б П x2 + 350 450 550 500 750 850 700 600 650");
        string[] lst_sectors = sectors.Split(' ');
        return lst_sectors[new Random().Next(lst_sectors.Length)];
    }
    static bool FindPrise(int money, int count, int cc)
    {
        Console.WriteLine("В какой шкатулке 5 000. 1 , 2 или 3");
        int ccn = new Random().Next(1, 3);
        if (cc == ccn)
        {
            Console.WriteLine("ПОБЕДА");
            money += 5000;
            count = 0;
            return true;
        }
        else { Console.WriteLine("эх"); count = 0; return false; }
    }

}
