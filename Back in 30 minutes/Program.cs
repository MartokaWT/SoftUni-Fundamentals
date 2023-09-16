using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 59)
            {
                hours += 1;
                if (hours > 23)
                {
                    hours -= 24;
                }
                minutes -= 60;
            }
            if (minutes < 10)
            {
                Console.WriteLine(hours + ":" + "0" + minutes);
            }
            else if (minutes >= 10)
            {
                Console.WriteLine(hours + ":" + minutes);
            }

        }
    }
}