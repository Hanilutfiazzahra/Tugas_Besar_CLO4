using System;
using System.Collections.Generic;
using Tugas_Besar_CLO4.Config;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Services
{
    public class BookingService
    {
        private static BookingService _instance;
        private readonly GenericRepository<Booking> _bookingRepository;

        // Constructor di-lock menjadi private (Singleton)
        private BookingService()
        {
            _bookingRepository = new GenericRepository<Booking>();
        }

        // Akses instance
        public static BookingService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BookingService();
                }
                return _instance;
            }
        }

        // Method untuk menyimpan data booking baru
        public void SimpanBooking(Booking booking)
        {
            _bookingRepository.Add(booking);
        }

        // Ambil semua data dari semua user(admin)
        public List<Booking> GetSemuaRiwayat()
        {
            return _bookingRepository.GetAll();
        }

        // Ambil data khusus untuk user yang sedang login(customer)
        public List<Booking> GetRiwayatCustomer(string namaCustomer)
        {
            return _bookingRepository.Find(b => b.NamaPemesan.Equals(namaCustomer, StringComparison.OrdinalIgnoreCase));
        }
    }
}