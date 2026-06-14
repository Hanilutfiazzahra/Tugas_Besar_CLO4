using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Besar_CLO4.Entities
{
    public class LapanganRegular : Lapangan
    {
        public LapanganRegular(
            string id,
            string nama,
            string lokasi,
            double harga
        )

            : base(
                id,
                nama,
                lokasi,
                harga,
                "Regular"
            )
        {
        }
    }

}
