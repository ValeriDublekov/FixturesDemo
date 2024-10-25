using FixturesDemo._6.Dependent_fixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.Dependent_fixtures;

public class DBFixture : IAsyncLifetime
{
    public async Task InitializeAsync()
    {
        await Task.Delay(TimeSpan.FromMilliseconds(500));
        Logger.Log();

        GlobalFixtureRegistry.RegisterFixture(this);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}