using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Aplikasi_Reservasi_Lapangan_Badminton.Ravie
{
    public class ConfigService
    {
        private readonly IConfiguration _config;

        public ConfigService()
        {
            _config = new ConfigurationBuilder()
                .AddJsonFile("config/appsettings.json")
                .Build();
        }

        public decimal GetTax()
        {
            return _config.GetValue<decimal>("Tax");
        }

        public decimal GetDiscount()
        {
            return _config.GetValue<decimal>("Discount");
        }
    }
}