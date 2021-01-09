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

        
        [TestMethod]
        public void TestGetNextPermutation4Chars()
        {
            Permutations permu = new Permutations(new List<char>() { '2', '1', '0', '3' });

            String expected = "0123";
            Assert.AreEqual(expected, permu.GetPermutation(0));

            expected = "0132";
            Assert.AreEqual(expected, permu.GetPermutation(1));

            expected = "0213";
            Assert.AreEqual(expected, permu.GetPermutation(2));

            expected = "0231";
            Assert.AreEqual(expected, permu.GetPermutation(3));

            expected = "0312";
            Assert.AreEqual(expected, permu.GetPermutation(4));

            expected = "0321";
            Assert.AreEqual(expected, permu.GetPermutation(5));

            expected = "1023";
            Assert.AreEqual(expected, permu.GetPermutation(6));


        }

        [TestMethod]
        public void TestGetNextPermutation5Chars()
        {
            Permutations permu = new Permutations(new List<char>() { '2', '1', '0', '3', '4' });


            String expected = "01234";
            Assert.AreEqual(expected, permu.GetPermutation(0));

            expected = "01243";
            Assert.AreEqual(expected, permu.GetPermutation(1));

            expected = "01324";
            Assert.AreEqual(expected, permu.GetPermutation(2));

            expected = "01342";
            Assert.AreEqual(expected, permu.GetPermutation(3));

            expected = "01423";
            Assert.AreEqual(expected, permu.GetPermutation(4));

            expected = "01432";
            Assert.AreEqual(expected, permu.GetPermutation(5));

        }
        

    }
}
