using System;
using System.Collections.Generic;

namespace EveCombatLogModel
{
    public class Fitting
    {

        public string Name { get; set; }
        public List<CombatLogEntry> CombatLogEntries { get; set; }

        public Fitting()
        {
            CombatLogEntries = new List<CombatLogEntry>();
        }
    }
}
