using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Config;

namespace Testing
{
    [TestClass]
    public class ConfigServiceTests
    {
        [TestMethod]
        public void Singleton_ShouldReturnSameInstance()
        {
            ConfigService instance1 =
                ConfigService.Instance;

            ConfigService instance2 =
                ConfigService.Instance;

            Assert.AreSame(
                instance1,
                instance2
            );
        }

        [TestMethod]
        public void UpdateConfig_ShouldChangeTaxAndDiscount()
        {
            ConfigService config =
                ConfigService.Instance;

            decimal pajakAwal =
                config.GetTax();

            decimal diskonAwal =
                config.GetDiscount();

            config.UpdateConfig(
                0.15m,
                0.10m
            );

            Assert.AreEqual(
                0.15m,
                config.GetTax()
            );

            Assert.AreEqual(
                0.10m,
                config.GetDiscount()
            );

            // Revert (Kembalikan ke nilai asal)
            config.UpdateConfig(
                pajakAwal,
                diskonAwal
            );
        }
    }
}