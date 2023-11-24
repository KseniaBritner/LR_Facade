using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFacade;

namespace ProgramFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.On();
            facade.Off();
        }
    }
}
