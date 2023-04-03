using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseList_Test
{
    [TestClass]
     class Swap_Testing
    {
        [TestMethod]
        public void Swap_Test() 
        {
            string input = "3\nlisten silent\nabc def\ntriangle integral\n";
            string expectedOutput = "YES\nNO\nYES\n";

            using var consoleInput = new StringReader(input);
            using var consoleOutput = new StringWriter();

            Console.SetIn(consoleInput);
            Console.SetOut(consoleOutput);

            // Act
            Program.Main(new string[] { });

            // Assert
            Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        }
    }
}
