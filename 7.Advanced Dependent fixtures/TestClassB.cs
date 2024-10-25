using FixturesDemo._7.Advanced_Dependent_fixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._7.Advanced_Dependent_fixtures;

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