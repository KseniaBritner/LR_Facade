using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacade
{
    internal class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }
        public void Mode()
        {
            Console.WriteLine("Канал переключен");
        }
    }
}
