using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Services;
using System.Linq;

namespace Testing
{
    [TestClass]
    public class LapanganServiceTests
    {
        [TestMethod]
        public void GetLapanganByGedung_ShouldReturnOnlySelectedBuilding()
        {
            LapanganService service =
                new LapanganService();

            var hasil =
                service.GetLapanganByGedung(
                    "Gedung B"
                );

            Assert.AreEqual(
                2,
                hasil.Count
            );

            Assert.IsTrue(
                hasil.All(
                    x => x.lokasi == "Gedung B"
                )
            );
        }
    }
}
