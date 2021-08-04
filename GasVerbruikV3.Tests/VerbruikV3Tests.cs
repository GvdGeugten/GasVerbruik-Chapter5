namespace GasVerbruikV3.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using GasVerbruikV3.Entities;

    [TestClass]
    public class VerbruikV3Tests
    {
        private int[] Jaren = new int[] { 1965, 1975, 1988, 2000, 2010 };

        [TestMethod]
        public void GasVerbruikWoningType1Test()
        {
            // Arrange
            var verbruik = new int[] { 1511, 1224, 1007, 755, 720 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.Portiekwoning, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType2Test()
        {
            // Arrange
            var verbruik = new int[] { 1532, 1241, 1021, 766, 730 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.Flat, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType3Test()
        {
            // Arrange
            var verbruik = new int[] { 1616, 1309, 1077, 808, 770 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.Galerijwoning, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType4Test()
        {
            // Arrange
            var verbruik = new int[] { 1679, 1360, 1119, 839, 800 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.Maisonnette, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType5Test()
        {
            // Arrange
            var verbruik = new int[] { 2414, 1955, 1609, 1207, 1150 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.Rijtjeswoning, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType6Test()
        {
            // Arrange
            var verbruik = new int[] { 2729, 2210, 1819, 1364, 1300 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.TweeOnderEenKap, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType7Test()
        {
            // Arrange
            var verbruik = new int[] { 2834, 2295, 1889, 1417, 1350 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.VrijstaandKlein, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }

        [TestMethod]
        public void GasVerbruikWoningType8Test()
        {
            // Arrange
            var verbruik = new int[] { 2939, 2380, 1959, 1469, 1400 };

            for (var index = 0; index < Jaren.Length; index++)
            {
                var jaar = Jaren[index];
                // Act
                var bereken = new BerekenGasVerbruik(WoningType.VrijstaandGroot, jaar);

                //Assert
                Assert.AreEqual(bereken.GeefJaarVerbruik(), verbruik[index]);
            }
        }
    }
}
