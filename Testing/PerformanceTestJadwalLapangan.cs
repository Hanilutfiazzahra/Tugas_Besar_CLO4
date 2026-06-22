using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class PerformanceTestJadwalLapangan
    {
        [TestMethod]
        public void GenerateJadwalPerformance()
        {
            Stopwatch stopwatch =
                new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
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
            }

            stopwatch.Stop();

            Debug.WriteLine(
                "Generate Jadwal 1000x = "
                + stopwatch.ElapsedMilliseconds
                + " ms"
            );
        }

        [TestMethod]
        public void FilterGedungPerformance()
        {
            Stopwatch stopwatch =
                new Stopwatch();

            LapanganService service =
                new LapanganService();

            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                service.GetLapanganByGedung(
                    "Gedung A"
                );
            }

            stopwatch.Stop();

            Debug.WriteLine(
                "Filter Gedung 1000x = "
                + stopwatch.ElapsedMilliseconds
                + " ms"
            );
        }
    }
}