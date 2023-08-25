using System;

namespace ParittomatLuvut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Käydään läpi kaikki luvut väliltä 1-99 ja tulostetaan parittomat luvut
            for (int luku = 1; luku < 100; luku += 2)
            {
                Console.WriteLine(luku);
            }
        }
    }
}

