using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._4._Base_tests_class;

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