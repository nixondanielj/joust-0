using DotNetCore.Joust;
using Xunit;

namespace DotNetCore.Test
{
    public class Joust_IsLinkValidShould
    {
        private readonly IJoust solution;

        public Joust_IsLinkValidShould()
        {
            // TODO: create system under test
            solution = null;
        }

        [Fact]
        public void ReturnTrueForOnshore()
        {
            bool result = solution.IsLinkValid("https://onshoreoutsourcing.com");
            Assert.True(result);
        }
    }
}
