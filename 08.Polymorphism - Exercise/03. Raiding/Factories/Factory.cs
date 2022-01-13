﻿using Raiding2.Models;

namespace Raiding2.Factories
{
    public class Factory
    {
        public BaseHero GetHero(string name, string type)
        {
            BaseHero hero = null;

            if(type == "Druid")
            {
                hero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);
            }

            return hero;
        }
    }
}
