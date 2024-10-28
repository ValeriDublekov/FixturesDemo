using FixturesDemo._6.DependentFixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.DependentFixtures;

public class TestClassAFixture : IAsyncLifetime
{
    public DBFixture DBFixture { get; private set; } = default!;

    public async Task InitializeAsync()
    {
        DBFixture = await GlobalFixtureRegistry.GetDBFixtureAsync();
        Logger.Log();
    }

    public Task DisposeAsync() => Task.CompletedTask;
}