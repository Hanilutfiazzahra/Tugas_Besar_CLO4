using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class PerformanceFilterTests
    {
        [TestMethod]
        public void FilterPerformance_10000Data()
        {
            var service = new FilterService();

            List<FilterJadwal> data =
                new List<FilterJadwal>();

            string[] daftarGedung =
            {
                "Gedung A",
                "Gedung B",
                "Gedung C"
            };

            for (int i = 0; i < 10000; i++)
            {
                data.Add(new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = daftarGedung[i % 3]
                });
            }

            Stopwatch stopwatch =
                new Stopwatch();

            stopwatch.Start();

            var hasil = service.FilterData(
                data,
                x => x.Gedung == "Gedung A"
            );

            stopwatch.Stop();

            long waktu =
                stopwatch.ElapsedMilliseconds;

            Console.WriteLine(
                $"Execution Time = {waktu} ms"
            );

            Assert.IsTrue(waktu < 1000);
        }
    }
}