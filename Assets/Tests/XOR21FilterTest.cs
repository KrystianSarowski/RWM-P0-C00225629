using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class XOR21FilterTest
    {
        [Test]
        public void XOR21FilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = XOR21Filter.xor21s(input);
            int[] expected = { 17, 23, 29, 22, 28, 17, 31, };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void XOR21FilterNegatives()
        {
            int[] input = { -4, -2, -8, -3, -9, -4, -10 };
            int[] output = XOR21Filter.xor21s(input);
            int[] expected = { -23, -21, -19, -24, -30, -23, -29 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void XOR21FilterLargetsInt()
        {
            int input = 2147483647;
            int output = XOR21Filter.xor21(input);
            int expected = 2147483626;

            Debug.Log(output);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void XOR21FilterSmallestInt()
        {
            int input = -2147483647;
            int output = XOR21Filter.xor21(input);
            int expected = -2147483628;

            Debug.Log(output);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void XOR21FilterZero()
        {
            int input = 0;
            int output = XOR21Filter.xor21(input);
            int expected = 21;

            Debug.Log(output);

            Assert.AreEqual(expected, output);
        }
    }
}