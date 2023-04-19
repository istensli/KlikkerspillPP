﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerspillPP
{
    internal class NormalUpgradeCommand : ICommand
    {
        private ClickerGame _clickerGame;
        public char Character { get; private set; }

        public NormalUpgradeCommand(ClickerGame clickerGame) 
        {
            _clickerGame = clickerGame;
            Character = 'K';
        }
        public void Run()
        {
            _clickerGame.NormalUpgrade();
        }
    }
}
