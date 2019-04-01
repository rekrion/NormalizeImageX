using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NormalizeImage;

namespace UnitTestNormalizeImage
{
    [TestClass]
    public class UnitTestNormalizeImage
    {
        [TestMethod]
        public void TestMethod256()
        {
            Stribog hash256 = new Stribog(SizeHash.Size256);
            string inputTest = "210987654321098765432109876543210987654321098765432109876543210";
            string result = "00-55-7B-E5-E5-84-FD-52-A4-49-B1-6B-02-51-D0-5D-27-F9-4A-B7-6C-BA-A6-DA-89-0B-59-D8-EF-1E-15-9D";

            byte[] inputBytes = Encoding.UTF8.GetBytes(inputTest);
            byte[] hash = hash256.GetHash(inputBytes);
            string h256 = BitConverter.ToString(hash);
            Assert.AreEqual(result,h256);
        }
        [TestMethod]
        public void TestMethod512()
        {
            Stribog hash512 = new Stribog(SizeHash.Size512);
            string inputTest = "210987654321098765432109876543210987654321098765432109876543210";
            string result = "48-6f-64-c1-91-78-79-41-7f-ef-08-2b-33-81-a4-e2-11-c3-24-f0-" +
                "74-65-4c-38-82-3a-7b-76-f8-30-ad-00-fa-1f-ba-e4-2b-12-85-c0-35-2f-22-75-" +
                "24-bc-9a-b1-62-54-28-8d-d6-86-3d-cc-d5-b9-f5-4a-1a-d0-54-1b";

            byte[] inputBytes= Encoding.UTF8.GetBytes(inputTest);
            byte[] hash= hash512.GetHash(inputBytes);
            string h512 = BitConverter.ToString(hash);
            Assert.AreEqual(result.ToUpper(), h512);
        }
    }
}
