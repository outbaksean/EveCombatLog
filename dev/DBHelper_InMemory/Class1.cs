using System;
using System.Collections.Generic;
using EveCombatLogModel;

namespace DBHelper_InMemory
{
    public class DBHelper : IDBHelper
    {

        private Dictionary<string, Fitting> _fittings;

        public void CreateCombatLogEntry(string fittingName, CombatLogEntry combatLogEntry)
        {
            throw new NotImplementedException();
        }

        public void CreateFitting(Fitting fitting)
        {
            throw new NotImplementedException();
        }

        public void DeleteCombatLogEntry(string combatLogEntryName)
        {
            throw new NotImplementedException();
        }

        public void DeleteFitting(string fittingName)
        {
            throw new NotImplementedException();
        }

        public List<Fitting> GetAllFittings()
        {
            throw new NotImplementedException();
        }

        public List<CombatLogEntry> GetCombatLogEntries(string fittingName)
        {
            throw new NotImplementedException();
        }

        public CombatLogEntry GetCombatLogEntry(string combatLogEntryName)
        {
            throw new NotImplementedException();
        }

        public Fitting GetFitting(string fittingName)
        {
            throw new NotImplementedException();
        }

        public void UpdateCombatLogEntry(string combatLogEntryName, CombatLogEntry combatLogEntry)
        {
            throw new NotImplementedException();
        }

        public void UpdateFitting(string fittingName, Fitting fitting)
        {
            throw new NotImplementedException();
        }
    }
}
