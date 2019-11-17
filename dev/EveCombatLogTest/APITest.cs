using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EveCombatLogTest
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void GetAllFittings()
        {
            //Arrange
            var api = new EveCombatLogAPILibrary.API();

            //Act
            var fittings = api.GetAllFittings();

            //Assert
            Assert.AreEqual("All Fittings".ToUpperInvariant(), fittings.ToUpperInvariant());
        }
    }
}
