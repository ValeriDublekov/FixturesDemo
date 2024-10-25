using FixturesDemo._6.Dependent_fixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.Dependent_fixtures;

public class TestClassB : BaseTestClass
{
    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}