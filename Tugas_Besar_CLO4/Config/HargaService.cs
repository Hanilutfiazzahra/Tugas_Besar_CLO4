using System;

namespace Tugas_Besar_CLO4.Config
{
    public class HargaService
    {
        private readonly ConfigService _config;

        public HargaService(ConfigService config)
        {
            _config = config;
        }

        public decimal HitungHarga(decimal hargaAwal)
        {
            if (hargaAwal < 0)
            {
                throw new Exception("Harga tidak boleh negatif");
            }

            decimal discount = _config.GetDiscount();
            decimal tax = _config.GetTax();

            decimal hasil = hargaAwal - (hargaAwal * discount);
            hasil += hasil * tax;

            return hasil;
        }
    }
}