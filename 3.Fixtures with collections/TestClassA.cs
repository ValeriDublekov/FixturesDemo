using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._3.Fixtures_with_collections;

[Collection(nameof(FixtureCollection3))]
public class TestClassA //: IClassFixture<Fixture3>
{
    private readonly Fixture3 _fixture;

    public TestClassA(Fixture3 fixture)
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