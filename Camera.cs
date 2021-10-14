using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    class Camera
    {
        public static void C()
        {
            Random rnd = new Random();
            int car = rnd.Next(-10, 10);
            if (car < 0)
            {
                Console.WriteLine("Путь свободен для поезда");

            }

            else
            {
                Console.WriteLine("Машина на путях.Сообщить данные диспетчеру");

            }
        }
    }
}
