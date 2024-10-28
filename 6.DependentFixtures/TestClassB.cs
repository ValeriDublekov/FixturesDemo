using FixturesDemo._6.DependentFixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.DependentFixtures;

public class TestClassB : BaseTestClass
{
    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}