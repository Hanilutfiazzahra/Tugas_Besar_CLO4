using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class ScheduleRangeTests
    {
        [TestMethod]
        public void GenerateJadwal_ShouldContainCorrectTimeRange()
        {
            LapanganRegular lapangan =
                new LapanganRegular(
                    "L001",
                    "Court A",
                    "Gedung A",
                    50000
                );

            ScheduleService service =
                new ScheduleService();

            service.generateJadwal(
                lapangan
            );

            Assert.IsTrue(
                lapangan.jadwal.ContainsKey(
                    "08.00 - 09.00"
                )
            );

            Assert.IsTrue(
                lapangan.jadwal.ContainsKey(
                    "21.00 - 22.00"
                )
            );
        }
    }
}
