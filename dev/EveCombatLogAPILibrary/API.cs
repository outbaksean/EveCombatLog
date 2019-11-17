using System;
using System.Collections.Generic;
using EveCombatLogModel;

namespace EveCombatLogAPILibrary
{
    public class API
    {

        public List<Fitting> GetAllFittings()
        {
            List<Fitting> fittings = new List<Fitting>();

            Fitting dummyFitting = new Fitting();
            dummyFitting.Name = "Dummy";
            fittings.Add(dummyFitting);

            return fittings;
        }

        public void CreateFitting(string fittingName)
        {
            //TODO
        }
    }
}
