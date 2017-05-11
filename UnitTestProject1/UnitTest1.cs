using System;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethodFail()
        {
            Assert.Equal(1, 1);
        }
        [Fact]
        public void TestMethodWorks()
        {
            Assert.Equal(2, 2);
        }
    }
}
