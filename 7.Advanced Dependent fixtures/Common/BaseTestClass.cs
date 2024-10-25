using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._7.Advanced_Dependent_fixtures.Common;

[Collection(nameof(DBFixtureFixtureCollection))]
public class BaseTestClass : IAsyncLifetime
{
    protected DBFixture DBFixture { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        DBFixture = await GlobalFixtureRegistry.GetFixtureAsync<DBFixture>();
        Logger.Log();
    }

    public Task DisposeAsync() => Task.CompletedTask;
}