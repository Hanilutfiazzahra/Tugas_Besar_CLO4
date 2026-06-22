using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Entities;

namespace Testing
{
    [TestClass]
    public class LapanganVIPTests
    {
        [TestMethod]
        public void GetDetail_ShouldContainFacilities()
        {
            LapanganVIP vip =
                new LapanganVIP(
                    "L002",
                    "Court B",
                    "Gedung A",
                    80000,
                    new string[]
                    {
                        "AC",
                        "LED",
                        "Sofa"
                    }
                );

            string detail =
                vip.getDetail();

            Assert.IsTrue(
                detail.Contains("AC")
            );

            Assert.IsTrue(
                detail.Contains("LED")
            );

            Assert.IsTrue(
                detail.Contains("Sofa")
            );
        }
    }
}
