using FixturesDemo._6.Dependent_fixtures.Common;
using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._6.Dependent_fixtures;

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