using NUnit.Framework;
using TestStack.BDDfy;

namespace TestStack.Seleno.Samples.Movies.FunctionalTests.UserStories
{
    [TestFixture]
    public class BDDfyFixture<TStory> where TStory : class
    {
        [Test]
        public void BDDfyMe()
        {
            this.BDDfy<TStory>();
        }
    }
}