using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._1.BasicFixtures;

public class Fixture1 : IAsyncLifetime, IDisposable
{
    public Fixture1()
    {
        Logger.Log();
    }

    public Task InitializeAsync()
    {
        Logger.Log();
        return Task.CompletedTask;
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