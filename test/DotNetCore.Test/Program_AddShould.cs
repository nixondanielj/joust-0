using System;
using DotNetCore.Joust;
using Xunit;

namespace DotNetCore.Test
{
    public class Program_AddShould
    {
        private readonly IJoust solution;

        public Program_AddShould()
        {
            solution = new Program();
        }

        [Fact]
        public void ReturnFourAddingTwoAndTwo()
        {
            int result = solution.Add(2, 2);
            Assert.Equal(result, 4);
        }
    }
}
