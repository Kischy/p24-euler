using Microsoft.VisualStudio.TestTools.UnitTesting;
using p24_euler;
using System.Collections.Generic;

namespace p24_euler_Tests
{
    [TestClass]
    public class LexicographicPermutationsTests
    {
        Permutations permu = new Permutations();


        [TestMethod]
        public void TestGetNextPermutation1()
        {
            List<char> current = new List<char>() { '0', '1', '2' };
            List<char> expected = new List<char>() { '0', '2', '1' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }

        [TestMethod]
        public void TestGetNextPermutation2()
        {
            List<char> current = new List<char>() { '0', '2', '1' };
            List<char> expected = new List<char>() { '1', '0', '2' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }

        [TestMethod]
        public void TestGetNextPermutation3()
        {
            List<char> current = new List<char>() { '0', '1', '2', '3' };
            List<char> expected = new List<char>() { '0', '1', '3', '2' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }

        [TestMethod]
        public void TestGetNextPermutation4()
        {
            List<char> current = new List<char>() { '0', '1', '3', '2' };
            List<char> expected = new List<char>() { '0', '2', '1', '3' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }

        [TestMethod]
        public void TestGetNextPermutation5()
        {
            List<char> current = new List<char>() { '0', '2', '1', '3' };
            List<char> expected = new List<char>() { '0', '2', '3', '1' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }

        [TestMethod]
        public void TestGetNextPermutation6()
        {
            List<char> current = new List<char>() { '0', '2', '3', '1' };
            List<char> expected = new List<char>() { '0', '3', '2', '1' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }

        [TestMethod]
        public void TestGetNextPermutation7()
        {
            List<char> current = new List<char>() { '0', '3', '2', '1' };
            List<char> expected = new List<char>() { '1', '0', '2', '3' };

            CollectionAssert.AreEqual(expected, permu.GetNextPermutation(current));
        }
    }
}
