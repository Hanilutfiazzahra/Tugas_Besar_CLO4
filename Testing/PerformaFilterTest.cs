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

            List<FilterJadwal> data = new List<FilterJadwal>();

            for (int i = 0; i < 10000; i++)
            {
                data.Add(new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = i % 2 == 0
                        ? "Gedung A"
                        : "Gedung B"
                });
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            var hasil = service.FilterData(data, x => x.Gedung == "Gedung A");

            stopwatch.Stop();

            long waktu = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Execution Time = {waktu} ms");

            Assert.IsTrue( waktu < 1000);
        }
    }
}