using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerspillPP
{
    internal interface ICommand
    {
        char Character { get; }
        void Run();
    }
}
