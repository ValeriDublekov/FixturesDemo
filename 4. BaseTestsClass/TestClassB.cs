using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._4._BaseTestsClass;

public class TestClassB : BaseTestClass
{
    public TestClassB(Fixture4 fixture) : base(fixture)
    {
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}