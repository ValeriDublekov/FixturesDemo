using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.DependentFixtures.Common;

[Collection(nameof(DBFixtureCollection))]
public class BaseTestClass : IAsyncLifetime
{
    protected DBFixture DBFixture { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        DBFixture = await GlobalFixtureRegistry.GetDBFixtureAsync();
        Logger.Log();
    }

    public Task DisposeAsync() => Task.CompletedTask;
}