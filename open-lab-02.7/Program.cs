using System;

namespace open_lab_02._7
{
    class Program
    {

        public static bool IsTimeForMilkAndCookies(int year, int month, int day)
        {
            return (true);
        }

        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            if (month == 12)
            {
                if (day == 24)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
