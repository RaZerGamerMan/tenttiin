using System;

namespace Exercise_Enums
{
    public enum CarBody
    {
        Coupé = 3,
        Sedan,
        HatchBack,
        StationWagon
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)CarBody.Sedan);
            Console.ReadLine();
        }
    }