using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._2.FixturesWithoutCollections;

public class TestClassB : IClassFixture<Fixture1>
{
    private readonly Fixture1 _fixture;

    public TestClassB(Fixture1 fixture)
    {
        _fixture = fixture;
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

