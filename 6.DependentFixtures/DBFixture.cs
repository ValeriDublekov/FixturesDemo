using FixturesDemo._6.DependentFixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.DependentFixtures;

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