using ConsoleApp2;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PurchaseList_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                // Arrange
                string input = "1.50 2.00 2.00 3.25 1.50 4.00 5.00 4.00";
                string expectedOutput = "Prices sold only once:\n3.25\n5.00\n";
                System.IO.StringReader reader = new System.IO.StringReader(input);
                Console.SetIn(reader);
                System.IO.StringWriter writer = new System.IO.StringWriter();
                Console.SetOut(writer);

                // Act
                Program.Main(new string[0]);
                string actualOutput = writer.ToString();

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }

            [TestMethod]
            public void TestPricesSoldMultipleTimes()
            {
                // Arrange
                string input = "1.00 2.00 3.00 1.00 2.00 4.00 5.00 5.00";
                string expectedOutput = "Prices sold only once:\n3.00\n4.00\nPrices sold more than once:\n1.00\n2.00\n5.00\n";
                System.IO.StringReader reader = new System.IO.StringReader(input);
                Console.SetIn(reader);
                System.IO.StringWriter writer = new System.IO.StringWriter();
                Console.SetOut(writer);

                // Act
                Program.Main(new string[0]);
                string actualOutput = writer.ToString();

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
    }
