using System;
using System.IO;
using System.Text.Json;

namespace Tugas_Besar_CLO4.Config
{
    public class ConfigService
    {
        private static ConfigService _instance;

        private readonly string _filePath = "Config/appsettings.json";
        private AppConfig _currentConfig;

        // Constructor private agar tidak bisa sembarangan dipanggil menggunakan 'new'
        private ConfigService()
        {
            LoadConfig();
        }

        // Properti publik untuk mengakses instance tunggal (Singleton)
        public static ConfigService Instance
        {
            get
            {
                // Jika belum pernah dibuat, maka buat baru. Jika sudah, kembalikan yang lama.
                if (_instance == null)
                {
                    _instance = new ConfigService();
                }
                return _instance;
            }
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    _currentConfig = JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig { Tax = 0.11m, Discount = 0.05m };
                }
                else
                {
                    _currentConfig = new AppConfig { Tax = 0.11m, Discount = 0.05m };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error membaca config: {ex.Message}");
                _currentConfig = new AppConfig { Tax = 0.11m, Discount = 0.05m };
            }
        }

        public decimal GetTax() => _currentConfig.Tax;
        public decimal GetDiscount() => _currentConfig.Discount;

        public void UpdateConfig(decimal newTax, decimal newDiscount)
        {
            _currentConfig.Tax = newTax;
            _currentConfig.Discount = newDiscount;

            var directoryInfo = new FileInfo(_filePath).Directory;
            if (directoryInfo != null && !directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(_currentConfig, options);
            File.WriteAllText(_filePath, json);
        }
    }
}