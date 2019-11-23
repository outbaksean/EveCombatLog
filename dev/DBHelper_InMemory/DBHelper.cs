using System;
using System.Collections.Generic;
using System.Linq;
using EveCombatLogModel;

namespace DBHelper_InMemory
{
    public class DBHelper : IDBHelper
    {

        private Dictionary<string, Fitting> _fittings;
        //private Dictionary<string, CombatLogEntry> _combatLogEntries;

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
            var query = from Fitting fitting in _fittings.Values
                        from CombatLogEntry combatLogEntry in fitting.CombatLogEntries
                        where combatLogEntry.Name == combatLogEntryName
                        select fitting;
            var fittingContainer = query.First<Fitting>();
            CombatLogEntry toDelete = null;
            foreach (CombatLogEntry combatLogEntry in fittingContainer.CombatLogEntries)
            {
                if (combatLogEntry.Name == combatLogEntryName)
                {
                    toDelete = combatLogEntry;
                }
            }
            if (!(toDelete == null))
            {
                fittingContainer.CombatLogEntries.Remove(toDelete);
            }
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
            var query = from Fitting fitting in _fittings.Values
                        from CombatLogEntry combatLogEntry in fitting.CombatLogEntries
                        where combatLogEntry.Name == combatLogEntryName
                        select combatLogEntry;
            return query.First<CombatLogEntry>();
            //if (query.Count() > 0)
            //{
            //    return query.First<CombatLogEntry>();
            //} else
            //{
            //    return null;
            //}
        }

        public Fitting GetFitting(string fittingName)
        {
            return _fittings[fittingName];
        }

        public void Init()
        {
            _fittings = new Dictionary<string, Fitting>();
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
