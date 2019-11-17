using Microsoft.VisualStudio.TestTools.UnitTesting;
//using EveCombatLogAPILibrary;
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
    }
}
