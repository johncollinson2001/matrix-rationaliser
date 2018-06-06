using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixRationaliser.Tests
{
    [TestClass]
    public class MatrixRationaliserServiceTests
    {
        [TestMethod]
        public void TestRationaliseMatrixReturnsExpectedResult_1()
        {
            var input = new int[][]
           {
                new int[] { 1, 2, 3, 5 },
                new int[] { 1, 0, 3, 5 },
                new int[] { 1, 2, 0, 5 },
                new int[] { 1, 2, 3, 5 }
           };

            var expectedOutput = new int[][]
            {
                new int[] { 1, 0, 0, 5 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 5 }
            };

            var output = MatrixRationaliserService.RationaliseMatrix(input, 0);

            for (var row = 0; row < output.Length; row++)
            {
                CollectionAssert.AreEqual(output[row], expectedOutput[row]);
            }
        }

        [TestMethod]
        public void TestRationaliseMatrixReturnsExpectedResult_2()
        {
            var input = new int[][]
           {
                new int[] { 1, 2, 3, 0 },
                new int[] { 1, 0, 3, 5 },
                new int[] { 1, 2, 0, 5 },
                new int[] { 0, 2, 3, 5 }
           };

            var expectedOutput = new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 }
            };

            var output = MatrixRationaliserService.RationaliseMatrix(input, 0);

            for (var row = 0; row < output.Length; row++)
            {
                CollectionAssert.AreEqual(output[row], expectedOutput[row]);
            }
        }

        [TestMethod]
        public void TestRationaliseMatrixReturnsExpectedResult_3()
        {
            var input = new int[][]
           {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 }
           };

            var expectedOutput = new int[][]
            {
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 }
            };

            var output = MatrixRationaliserService.RationaliseMatrix(input, 0);

            for (var row = 0; row < output.Length; row++)
            {
                CollectionAssert.AreEqual(output[row], expectedOutput[row]);
            }
        }

        [TestMethod]
        public void TestRationaliseMatrixReturnsExpectedResult_4()
        {
            var input = new int[][]
           {
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 }
           };

            var expectedOutput = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2, 3, 4 }
            };

            var output = MatrixRationaliserService.RationaliseMatrix(input, 0);

            for (var row = 0; row < output.Length; row++)
            {
                CollectionAssert.AreEqual(output[row], expectedOutput[row]);
            }
        }
    }
}
