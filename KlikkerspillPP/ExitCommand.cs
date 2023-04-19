using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerspillPP
{
    internal class ExitCommand : ICommand
    {

        public char Character { get; private set; }

        public ExitCommand()
        {
            Character = 'X';
        }
        public void Run() 
        {
            Console.WriteLine("Exit Command");
        }
    }
}
