using System;
using Xunit;
using Xunit.Abstractions;

namespace BDDXUnit.Tests
{
    public class TestClass
    {
        private readonly ITestOutputHelper _testOutput;

        public TestClass( ITestOutputHelper testOutput )
        {
            _testOutput = testOutput;
        }
       


        [ Fact]
        public void Test1()
        {

        }
    }
}
