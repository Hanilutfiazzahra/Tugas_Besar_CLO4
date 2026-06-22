using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Config;

namespace Testing
{
    [TestClass]
    public class HargaServiceTests
    {
        [TestMethod]
        public void HitungHarga_ShouldCalculateCorrectly()
        {
            ConfigService config =
                ConfigService.Instance;

            decimal pajakAwal =
                config.GetTax();

            decimal diskonAwal =
                config.GetDiscount();

            // Tetapkan diskon 10% dan pajak 10% untuk pengujian
            config.UpdateConfig(
                0.10m,
                0.10m
            );

            HargaService service =
                new HargaService();

            decimal totalHarga =
                service.HitungHarga(100000m);

            // 100k - 10k (diskon) = 90k
            // 90k + 9k (pajak) = 99k
            Assert.AreEqual(
                99000m,
                totalHarga
            );

            // Revert (Kembalikan ke nilai awal)
            config.UpdateConfig(
                pajakAwal,
                diskonAwal
            );
        }

        [TestMethod]
        public void HitungHarga_NegativeValue_ShouldThrowException()
        {
            HargaService service =
                new HargaService();

            // Cara modern dalam MSTest untuk menguji error (Exception)
            var ex = Assert.Throws<Exception>(() =>
            {
                service.HitungHarga(-50000m);
            });

            // Memastikan pesan errornya tepat
            Assert.AreEqual(
                "Harga tidak boleh negatif",
                ex.Message
            );
        }
    }
}