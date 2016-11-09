using DotNetCore.Joust;
using Xunit;

namespace DotNetCore.Test
{
    public class Joust_IsLinkValidShould
    {
        private readonly IJoust solution;

        public Joust_IsLinkValidShould()
        {
            solution = new LinkTester();
        }

        [Fact]
        public void ReturnTrueForOnshore()
        {
            bool result = solution.IsLinkValid("http://www.onshoreoutsourcing.com");
            Assert.True(result);
        }

        [Fact]
        public void ReturnFalseForBadFormat()
        {
            bool result = solution.IsLinkValid("orange");
            Assert.False(result);
        }

        [Fact]
        public void ReturnFalseForNull()
        {
            bool result = solution.IsLinkValid(null);
            Assert.False(result);
        }

        [Fact]
        public void ReturnFalseForNotFoundUrl()
        {
            // response should be 404
            bool result = solution.IsLinkValid("http://www.onshoreoutsourcing.com/foo");
            Assert.False(result);
        }

        [Fact]
        public void ReturnFalseForNonexistentUrl()
        {
            bool result = solution.IsLinkValid("http://deadurl.fake");
            Assert.False(result);
        }

        [Fact]
        public void ReturnTrueForRedirect()
        {
            bool result = solution.IsLinkValid("http://onshoreoutsourcing.com");
            Assert.True(result);
        }
    }
}
