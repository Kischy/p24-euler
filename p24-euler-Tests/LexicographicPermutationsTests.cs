using Microsoft.VisualStudio.TestTools.UnitTesting;
using p24_euler;
using System;
using System.Collections.Generic;



namespace p24_euler_Tests
{
    [TestClass]
    public class LexicographicPermutationsTests
    {


        [TestMethod]
        public void TestGetNextPermutation3Chars()
        {
            Permutations permu = new Permutations(new List<char>() { '2', '1', '0' });

            String expected = "012";
            Assert.AreEqual(expected, permu.GetPermutation(0));

            expected = "021";
            Assert.AreEqual(expected, permu.GetPermutation(1));

            expected = "102";
            Assert.AreEqual(expected, permu.GetPermutation(2));
          

        }

        /*
        [TestMethod]
        public void TestGetNextPermutation4Chars()
        {
            Permutations permu = new Permutations(new List<char>() { '2', '1', '0', '3' });

            List<char> expected = new List<char>() { '0', '1', '2', '3' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '1', '3', '2' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '2', '1', '3' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '2', '3', '1' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '3', '2', '1' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '1', '0', '2', '3' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

        }

        [TestMethod]
        public void TestGetNextPermutation5Chars()
        {
            Permutations permu = new Permutations(new List<char>() { '2', '1', '0', '3', '4' });

            List<char> expected = new List<char>() { '0', '1', '2', '3', '4' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '1', '2', '4', '3' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '1', '3', '2', '4' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '1', '3', '4', '2' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '1', '4', '2', '3' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

            expected = new List<char>() { '0', '1', '4', '3', '2' };
            CollectionAssert.AreEqual(expected, permu.GetNextPermutation());

        }
        */

    }
}
