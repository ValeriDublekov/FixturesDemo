using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._4._Base_tests_class;

public class TestClassA : BaseTestClass
{
    public TestClassA(Fixture4 fixture): base(fixture)
    {
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }

    [Fact]
    public void Test_2()
    {
        Logger.Log();
    }
}