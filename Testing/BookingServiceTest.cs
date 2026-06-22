using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Services;

namespace Testing
{
    [TestClass]
    public class BookingServiceTest
    {
        [TestMethod]
        public void SimpanBooking_BerhasilDisimpan()
        {

            Booking booking = new()
            {
                NamaPemesan = "Ryan"
            };

            BookingService.Instance.SimpanBooking(booking);

            var data = BookingService.Instance.GetSemuaRiwayat();

            Assert.IsTrue(data.Contains(booking));
        }
    }
}