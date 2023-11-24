using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFacade
{
    internal class DVD
    {
        public void In()
        {
            Console.WriteLine("Диск вставлен");
        }
        public void Out()
        {
            Console.WriteLine("Диск извлечен");
        }
        public void Play()
        {
            Console.WriteLine("Проигрывание диска");
        }
    }
}
