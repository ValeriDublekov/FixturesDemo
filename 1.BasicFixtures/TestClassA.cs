using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._1.BasicFixtures;

public class TestClassA : IClassFixture<Fixture1>, IAsyncLifetime, IDisposable
{
    private readonly Fixture1 _fixture;

    public TestClassA(Fixture1 fixture)
    {
        _fixture = fixture;
        Logger.Log();
    }

    public Task InitializeAsync()
    {
        Logger.Log();
        return Task.CompletedTask;
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

    public Task DisposeAsync()
    {
        Logger.Log();
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        Logger.Log();
    }
}
