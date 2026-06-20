using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Besar_CLO4.Entities;
using Tugas_Besar_CLO4.Config;

namespace Tugas_Besar_CLO4.Services
{
    public class PaymentService
    {
        private readonly ConfigService _config;

        public PaymentService(ConfigService config)
        {
            _config = config;
        }

        public double HitungHargaAwal(Booking booking)
        {
            return booking.Lapangan.hargaPerJam *
                   booking.Durasi;
        }

        public double HitungPajak(double hargaAwal)
        {
            return hargaAwal *
                   (double)_config.GetTax();
        }

        public double HitungTotal(double hargaAwal)
        {
            double pajak =
                hargaAwal *
                (double)_config.GetTax();

            return hargaAwal + pajak;
        }
    }
}