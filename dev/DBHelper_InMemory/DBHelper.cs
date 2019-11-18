using System;
using System.Collections.Generic;
using System.Linq;
using EveCombatLogModel;

namespace DBHelper_InMemory
{
    public class DBHelper : IDBHelper
    {

        private Dictionary<string, Fitting> _fittings;
        private Dictionary<string, CombatLogEntry> _combatLogEntries;

        public void CreateCombatLogEntry(string fittingName, CombatLogEntry combatLogEntry)
        {
            Fitting fitting = _fittings[fittingName];
            fitting.CombatLogEntries.Add(combatLogEntry);
        }

        public void CreateFitting(Fitting fitting)
        {
            _fittings.Add(fitting.Name, fitting);
        }

        public void DeleteCombatLogEntry(string combatLogEntryName)
        {
            throw new NotImplementedException();
        }

        public void DeleteFitting(string fittingName)
        {
            _fittings.Remove(fittingName);
        }

        public List<Fitting> GetAllFittings()
        {
            return _fittings.Values.ToList();
        }

        public List<CombatLogEntry> GetCombatLogEntries(string fittingName)
        {
            Fitting fitting = _fittings[fittingName];
            return fitting.CombatLogEntries;
        }

        public CombatLogEntry GetCombatLogEntry(string combatLogEntryName)
        {
            return _combatLogEntries[combatLogEntryName];
        }

        public Fitting GetFitting(string fittingName)
        {
            return _fittings[fittingName];
        }

        public void UpdateCombatLogEntry(string combatLogEntryName, CombatLogEntry combatLogEntry)
        {
            throw new NotImplementedException();
        }

        public void UpdateFitting(string fittingName, Fitting fitting)
        {
            if (_fittings.ContainsKey(fittingName))
            {
                _fittings[fittingName] = fitting;
            }

        }
    }
}
