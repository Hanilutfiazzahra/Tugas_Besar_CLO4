using System.Collections.Generic;
using System.Linq;
using Tugas_Besar_CLO4.Entities;

namespace Tugas_Besar_CLO4.Services
{
    public class LapanganService
    {
        public List<Lapangan> GetLapanganByGedung(
            string gedung
        )
        {
            List<Lapangan> daftarLapangan =
                new List<Lapangan>()
                {
                    new LapanganRegular(
                        "L001",
                        "Court A",
                        "Gedung A",
                        50000
                    ),

                    new LapanganVIP(
                        "L002",
                        "Court B",
                        "Gedung A",
                        80000,
                        new string[]
                        {
                            "AC",
                            "LED",
                            "Sofa"
                        }
                    ),

                    new LapanganRegular(
                        "L003",
                        "Court C",
                        "Gedung B",
                        50000
                    ),

                    new LapanganVIP(
                        "L004",
                        "Court D",
                        "Gedung B",
                        80000,
                        new string[]
                        {
                            "AC",
                            "LED",
                            "Sofa"
                        }
                    ),

                    new LapanganRegular(
                        "L005",
                        "Court E",
                        "Gedung C",
                        50000
                    ),

                    new LapanganVIP(
                        "L006",
                        "Court F",
                        "Gedung C",
                        80000,
                        new string[]
                        {
                            "AC",
                            "LED",
                            "Sofa"
                        }
                    )
                };

            return daftarLapangan
                .Where(x => x.lokasi == gedung)
                .ToList();
        }
    }
}