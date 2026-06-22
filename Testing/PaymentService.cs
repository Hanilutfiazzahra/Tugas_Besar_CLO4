using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class PaymentServiceTests
    {
        [TestMethod]
        public void HitungPajak_HarusLebihBesarDariNol()
        {
            PaymentService service = new();

            double hasil = service.HitungPajak(100000);

            Assert.IsGreaterThan(0, hasil);
        }

        [TestMethod]
        public void HitungTotal_HarusLebihBesarDariHargaAwal()
        {
            PaymentService service = new();

            double total = service.HitungTotal(100000);

            Assert.IsGreaterThan(100000, total);
        }
    }
}