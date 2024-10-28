using FixturesDemo._7.AdvancedDependentFixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._7.AdvancedDependentFixtures;

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