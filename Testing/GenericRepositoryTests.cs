using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tugas_Besar_CLO4.Config;
using System.Linq;

namespace Testing
{
    [TestClass]
    public class GenericRepositoryTests
    {
        [TestMethod]
        public void AddAndGetAll_ShouldStoreAndReturnItems()
        {
            GenericRepository<string> repo =
                new GenericRepository<string>();

            repo.Add("Data 1");
            repo.Add("Data 2");

            var hasil =
                repo.GetAll();

            Assert.AreEqual(
                2,
                hasil.Count
            );

            Assert.AreEqual(
                "Data 1",
                hasil[0]
            );
        }

        [TestMethod]
        public void Find_ShouldFilterDataByCondition()
        {
            GenericRepository<int> repo =
                new GenericRepository<int>();

            repo.Add(10);
            repo.Add(20);
            repo.Add(30);

            var hasil = repo.Find(
                x => x > 15
            );

            Assert.AreEqual(
                2,
                hasil.Count
            );

            Assert.IsTrue(
                hasil.Contains(20) && hasil.Contains(30)
            );
        }
    }
}