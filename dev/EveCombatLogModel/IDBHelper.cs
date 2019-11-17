using System;
using System.Collections.Generic;
using System.Text;

namespace EveCombatLogModel
{
    public interface IDBHelper
    {
        public void CreateFitting(Fitting fitting);

        public List<Fitting> GetAllFittings();

        public Fitting GetFitting(string fittingName);

        public void UpdateFitting(string fittingName, Fitting fitting);

        public void DeleteFitting(string fittingName);

        public void CreateCombatLogEntry(string fittingName, CombatLogEntry combatLogEntry);

        public List<CombatLogEntry> GetCombatLogEntries(string fittingName);

        public CombatLogEntry GetCombatLogEntry(string combatLogEntryName);

        public void UpdateCombatLogEntry(string combatLogEntryName, CombatLogEntry combatLogEntry);

        public void DeleteCombatLogEntry(string combatLogEntryName);
    }
}
