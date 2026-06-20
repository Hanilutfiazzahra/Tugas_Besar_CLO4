using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Entities
{
    public class Booking
    {
        public string NamaPemesan { get; set; }

        public DateTime HariMulai { get; set; }

        public Lapangan Lapangan { get; set; }

        public string JamMulai { get; set; }

        public string JamSelesai { get; set; }

        public int Durasi { get; set; }

        public double HargaAwal { get; set; }

        public double Pajak { get; set; }

        public double TotalHarga { get; set; }

        public BookingState Status { get; set; }

        public Booking()
        {
            Status = BookingState.Pending;
        }

        public void Bayar()
        {
            if (Status == BookingState.Pending)
            {
                Status = BookingState.Paid;
            }
        }

        public void Batalkan()
        {
            if (Status == BookingState.Pending)
            {
                Status = BookingState.Cancelled;
            }
        }
    }
}