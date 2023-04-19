using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerspillPP
{
    internal class ClickCommand : ICommand
    {
        private ClickerGame _clickerGame;
        public char Character { get; private set; }

        public ClickCommand(ClickerGame clickerGame) 
        {
            _clickerGame = clickerGame;
            Character = ' ';
        }
        public void Run() 
        {
            _clickerGame.Click();
        }
    }
}
