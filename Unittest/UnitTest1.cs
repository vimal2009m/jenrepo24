namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from DevOps";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
