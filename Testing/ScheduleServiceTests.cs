using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class ScheduleServiceTests
    {
        [TestMethod]
        public void GenerateJadwal_ShouldCreate14ScheduleSlots()
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

            Assert.AreEqual(
                14,
                lapangan.jadwal.Count
            );
        }
    }
}
