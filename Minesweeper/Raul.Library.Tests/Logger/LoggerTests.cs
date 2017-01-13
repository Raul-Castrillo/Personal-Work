using NUnit.Framework;

namespace Raul.Library.Tests.Logger
{
    [TestFixture]
    [Ignore]
    public class LoggerTests
    {
        private Library.Logger.Logger _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Library.Logger.Logger();
            string path = @"C:\CustomRepos\Logs\Minesweeper";
            _sut.Initialize(path);
        }

        [Test]
        public void InitializeTest()
        {
            string path = @"C:\CustomRepos\Logs\Minesweeper";
            _sut.Initialize(path);
        }

        [Test]
        public void LogStringFormatTest()
        {
            _sut.Error("TEST {0}", "1");
        }
    }
}
