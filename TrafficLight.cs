using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    class TrafficLight
    {
        public static void T()
        {

            Random rnd = new Random();
            int s = rnd.Next(-10, 10);
            if (s > 0)
            {
                Console.WriteLine("Желтый");
                Barrier.B0();

            }


            else
            {
                Console.WriteLine("Крансый");
                Barrier.B1();

            }

        }

    }
}
