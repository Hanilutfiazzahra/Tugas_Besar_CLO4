using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Entities;

namespace Testing
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void Constructor_StatusAwalPending()
        {
            Booking booking = new();

            Assert.AreEqual(BookingState.Pending, booking.Status);
        }

        [TestMethod]
        public void Bayar_DariPending_MenjadiPaid()
        {
            Booking booking = new();

            booking.Bayar();

            Assert.AreEqual(BookingState.Paid, booking.Status);
        }

        [TestMethod]
        public void Batalkan_DariPending_MenjadiCancelled()
        {
            Booking booking = new();

            booking.Batalkan();

            Assert.AreEqual(BookingState.Cancelled, booking.Status);
        }
    }
}