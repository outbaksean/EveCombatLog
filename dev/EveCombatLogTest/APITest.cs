using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EveCombatLogAPILibrary;
//using DBHelper_InMemory;
using EveCombatLogModel;

namespace EveCombatLogTest
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void GetAllFittings_DummyFitName()
        {
            //Arrange
            var api = new EveCombatLogAPILibrary.API();

            //Act
            var fittings = api.GetAllFittings();

            //Assert
            var firstFitting = fittings[0];

            Assert.AreEqual("Dummy".ToUpperInvariant(), firstFitting.Name.ToUpperInvariant());
        }

        [TestMethod]
        public void FullDBHelper()
        {
            IDBHelper db = new DBHelper_InMemory.DBHelper();
            db.Init();

            Fitting firstFitting = new Fitting();
            string firstFittingName = "First Fitting Name";
            firstFitting.Name = firstFittingName;

            db.CreateFitting(firstFitting);

            var getFirstFitting = db.GetFitting(firstFittingName);
            Assert.AreEqual(getFirstFitting.Name.ToUpperInvariant(), firstFittingName.ToUpperInvariant());

            var allFittings = db.GetAllFittings();
            getFirstFitting = allFittings[0];
            Assert.AreEqual(getFirstFitting.Name.ToUpperInvariant(), firstFittingName.ToUpperInvariant());

            CombatLogEntry firstCombatLogEntry = new CombatLogEntry();
            string firstCombatLogEntryName = "First Combat Log Entry Name";
            firstCombatLogEntry.Name = firstCombatLogEntryName;

            db.CreateCombatLogEntry(firstFittingName, firstCombatLogEntry);

            var getCombatLogEntry = db.GetCombatLogEntry(firstCombatLogEntryName);
            Assert.AreEqual(getCombatLogEntry.Name.ToUpperInvariant(), firstCombatLogEntryName.ToUpperInvariant());

            CombatLogEntry secondCombatLogEntry = new CombatLogEntry();
            string secondCombatLogEntryName = "Second Combat Log Entry Name";
            secondCombatLogEntry.Name = secondCombatLogEntryName;

            db.CreateCombatLogEntry(firstFittingName, secondCombatLogEntry);

            getCombatLogEntry = db.GetCombatLogEntry(secondCombatLogEntryName);
            Assert.AreEqual(getCombatLogEntry.Name.ToUpperInvariant(), secondCombatLogEntryName.ToUpperInvariant());
        }
    }
}
