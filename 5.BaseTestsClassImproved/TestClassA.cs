using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._5.BaseTestsClassImproved;

public class TestClassA : BaseTestClass
{
    public TestClassA()
    {
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}