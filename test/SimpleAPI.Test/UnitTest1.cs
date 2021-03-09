using System;
using Xunit;
using SimpleAPI.Controllers;  // JP - Added 

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("John Pummill", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
