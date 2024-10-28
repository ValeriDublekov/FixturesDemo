using FixturesDemo._6.DependentFixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.DependentFixtures;

public class TestClassA : BaseTestClass, IClassFixture<TestClassAFixture>
{
    private readonly TestClassAFixture _testClassAFixture;

    public TestClassA(TestClassAFixture testClassAFixture)
    {
        _testClassAFixture = testClassAFixture;
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}