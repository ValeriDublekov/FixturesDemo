using FixturesDemo._7.AdvancedDependentFixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._7.AdvancedDependentFixtures;

public class TestClassB : BaseTestClass
{
    public TestClassB()
    {
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}