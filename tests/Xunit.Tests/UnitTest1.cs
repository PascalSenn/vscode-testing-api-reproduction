using System;
using Xunit;

namespace Xunit.Tests
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact(Skip = "Skipped")]
        public void Skipped()
        {

        }

        public void Test3()
        {
            throw new Exception("");
        }
    }
}