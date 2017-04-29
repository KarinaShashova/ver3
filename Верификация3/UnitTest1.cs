using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns;

namespace Верификация3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PatternCreationClass()
        {
            Pattern pattern = new Pattern();
            Assert.IsNotNull(pattern);
        }
    }
}
