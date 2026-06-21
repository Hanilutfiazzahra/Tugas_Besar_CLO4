using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Config;

namespace Tugas_Besar_CLO4.Services
{
    public class PaymentService
    {
        // Constructor kosong karena tidak perlu injeksi parameter lagi
        public PaymentService()
        {

        }

        public double HitungHargaAwal(Booking booking)
        {
            return booking.Lapangan.hargaPerJam * booking.Durasi;
        }

        public double HitungPajak(double hargaAwal)
        {
            // Ambil langsung dari Singleton
            return hargaAwal * (double)ConfigService.Instance.GetTax();
        }

        public double HitungTotal(double hargaAwal)
        {
            // Ambil langsung dari Singleton
            double pajak = hargaAwal * (double)ConfigService.Instance.GetTax();
            return hargaAwal + pajak;
        }
    }
}