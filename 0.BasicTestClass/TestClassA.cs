using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._0.BasicTestClass;

public class TestClassA : IAsyncLifetime, IDisposable
{
    public TestClassA()
    {
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
