using System;
using Xunit;

namespace myApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "A B C";
            string actual = myApp.Program.stringDecoder("AWUBBWUBC");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string expected = "A B C";
            string actual = myApp.Program.stringDecoder("AWUBWUBWUBBWUBWUBWUBC");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string expected = "A B C";
            string actual = myApp.Program.stringDecoder("WUBAWUBBWUBCWUB");
            Assert.Equal(expected, actual);
        }
    }
}
