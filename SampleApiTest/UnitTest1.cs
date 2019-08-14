using System;
using Xunit;
using SampleApi;
using SampleApi.Controllers;

namespace SampleApiTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ValuesController values1 = new ValuesController();
            Assert.Equal("HELLO", values1.HelloHi("hi"));
        }
        [Fact]
        public void Test2()
        {
            ValuesController values1 = new ValuesController();
            Assert.Equal("HI", values1.HelloHi("hELLO"));
        }

    }
}
