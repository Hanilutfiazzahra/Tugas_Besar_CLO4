using System;

namespace Tugas_Besar_CLO4.Config
{
    public class HargaService
    {
        // Constructor tidak perlu lagi menerima parameter ConfigService
        public HargaService()
        {

        }

        public decimal HitungHarga(decimal hargaAwal)
        {
            if (hargaAwal < 0)
            {
                throw new Exception("Harga tidak boleh negatif");
            }

            // Panggil Singleton Instance secara langsung
            decimal discount = ConfigService.Instance.GetDiscount();
            decimal tax = ConfigService.Instance.GetTax();

            decimal hasil = hargaAwal - (hargaAwal * discount);
            hasil += hasil * tax;

            return hasil;
        }
    }
}