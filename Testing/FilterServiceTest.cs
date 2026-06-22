using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class FilterServiceTests
    {
        private FilterService service = null!;

        [TestInitialize]
        public void Setup()
        {
            service = new FilterService();
        }

        [TestMethod]
        public void FilterData_BerdasarkanGedung_Berhasil()
        {
            var data = new List<FilterJadwal>
            {
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung A"
                },
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung B"
                },
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung C"
                }
            };

            var hasil = service.FilterData(
                data,
                x => x.Gedung == "Gedung A"
            );

            Assert.AreEqual(1, hasil.Count);
            Assert.AreEqual("Gedung A", hasil[0].Gedung);
        }

        [TestMethod]
        public void FilterData_BerdasarkanHari_Berhasil()
        {
            var data = new List<FilterJadwal>
            {
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung A"
                },
                new FilterJadwal
                {
                    Hari = DateTime.Today.AddDays(1),
                    Gedung = "Gedung B"
                },
                new FilterJadwal
                {
                    Hari = DateTime.Today.AddDays(2),
                    Gedung = "Gedung C"
                }
            };

            var hasil = service.FilterData(
                data,
                x => x.Hari.Date == DateTime.Today
            );

            Assert.AreEqual(1, hasil.Count);
            Assert.AreEqual(
                DateTime.Today,
                hasil[0].Hari.Date
            );
        }

        [TestMethod]
        public void FilterData_TidakAdaDataYangSesuai()
        {
            var data = new List<FilterJadwal>
            {
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung A"
                },
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung B"
                },
                new FilterJadwal
                {
                    Hari = DateTime.Today,
                    Gedung = "Gedung C"
                }
            };

            var hasil = service.FilterData(
                data,
                x => x.Gedung == "Gedung Z"
            );

            Assert.AreEqual(0, hasil.Count);
        }

        [TestMethod]
        public void FilterData_DataKosong_ReturnEmptyList()
        {
            var data = new List<FilterJadwal>();

            var hasil = service.FilterData(
                data,
                x => x.Gedung == "Gedung A"
            );

            Assert.AreEqual(0, hasil.Count);
        }

        [TestMethod]
        public void FilterData_DataNull_ThrowsException()
        {
            bool exceptionThrown = false;

            try
            {
                service.FilterData<FilterJadwal>(
                    null,
                    x => true
                );
            }
            catch (ArgumentNullException)
            {
                exceptionThrown = true;
            }

            Assert.IsTrue(exceptionThrown);
        }
    }
}