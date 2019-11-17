using System;
using System.Collections.Generic;
using EveCombatLogModel;

namespace EveCombatLogAPILibrary
{
    public class API
    {

        public void CreateFitting(Fitting fitting)
        {
            //TODO
        }

        public List<Fitting> GetAllFittings()
        {
            List<Fitting> fittings = new List<Fitting>();

            Fitting dummyFitting = new Fitting();
            dummyFitting.Name = "Dummy";
            fittings.Add(dummyFitting);

            return fittings;
        }

        public Fitting GetFitting(string fittingName)
        {
            Fitting dummyFitting = new Fitting();
            dummyFitting.Name = "Dummy";

            return dummyFitting;
        }

        public void UpdateFitting(string fittingName, Fitting fitting)
        {
            //TODO
        }

        public void DeleteFitting(string fittingName)
        {
            //TODO
        }

        public void CreateCombatLogEntry(string fittingName, CombatLogEntry combatLogEntry)
        {
            //TODO
        }

        public List<CombatLogEntry> GetCombatLogEntries(string fittingName)
        {
            List<CombatLogEntry> combatLogEntries = new List<CombatLogEntry>();

            CombatLogEntry dummyCombatLogEntry = new CombatLogEntry();
            dummyCombatLogEntry.Name = "Dummy";
            combatLogEntries.Add(dummyCombatLogEntry);

            return combatLogEntries;
        }

        public CombatLogEntry GetCombatLogEntry(string combatLogEntryName)
        {
            CombatLogEntry dummyCombatLogEntry = new CombatLogEntry();
            dummyCombatLogEntry.Name = "Dummy";

            return dummyCombatLogEntry;
        }

        public void UpdateCombatLogEntry(string combatLogEntryName, CombatLogEntry combatLogEntry)
        {
            //Todo
        }

        public void DeleteCombatLogEntry(string combatLogEntryName)
        {
            //Todo
        }
    }
}
