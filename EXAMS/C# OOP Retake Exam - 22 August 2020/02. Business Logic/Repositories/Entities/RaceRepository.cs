﻿using System.Collections.Generic;
using EasterRaces.Models.Races.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : Repository<IRace>
    {
        private readonly ICollection<IRace> races;

        public RaceRepository()
        {
            races = new List<IRace>();
        }
    }
}
