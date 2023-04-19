using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerspillPP
{
    internal class SuperUpgradeCommand : ICommand
    {
        private ClickerGame _clickerGame;
        public char Character { get; private set; }

        public SuperUpgradeCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
            Character = 'S';
        }
        public void Run()
        {
            _clickerGame.SuperUpgrade();
        }
    }
}
