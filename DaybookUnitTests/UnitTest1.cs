using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayBook;

namespace DaybookUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMin()
        {
            // Arrange
            string data = string.Empty;
            TaskOperations tOper = new TaskOperations();

            // Act
            int res = tOper.CheckTaskCorrect(data);

            // Assert
            Assert.AreEqual(-1, res, 0.001, "Problems with getting wrong small data");
        }

        [TestMethod]
        public void TestOKMin()
        {
            // Arrange
            string data = "1";
            TaskOperations tOper = new TaskOperations();

            // Act
            int res = tOper.CheckTaskCorrect(data);

            // Assert
            Assert.AreEqual(0, res, 0.001, "Problems with getting correct small data");
        }

        [TestMethod]
        public void TestMax()
        {
            // Arrange
            string data = string.Empty;
            for (int i = 0; i < 1001; i++)
                data += '1';

            TaskOperations tOper = new TaskOperations();

            // Act
            int res = tOper.CheckTaskCorrect(data);

            // Assert
            Assert.AreEqual(1, res, 0.001, "Problems with getting wrong large data");
        }

        [TestMethod]
        public void TestOKMax()
        {
            // Arrange
            string data = string.Empty;
            for (int i = 0; i < 100; i++)
                data += '1';
            TaskOperations tOper = new TaskOperations();

            // Act
            int res = tOper.CheckTaskCorrect(data);

            // Assert
            Assert.AreEqual(0, res, 0.001, "Problems with getting correct large data");
        }
    }
}
