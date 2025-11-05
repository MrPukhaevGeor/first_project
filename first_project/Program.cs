using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class MainClass
{
    public static void Main()
    {
        int l = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine(GenereateNum(l, r));
    }
static int GenereateNum(int l, int r)
    {
        int n = new Random().Next(l, r);
        //Console.WriteLine(n);
        return n;
    }
}
