using Xunit;

namespace FixturesDemo._7.Advanced_Dependent_fixtures.Common;

public abstract class AutoRegisteringFixture : IAsyncLifetime
{
    protected abstract Task InitializeFixtureAsync();

    public async Task InitializeAsync()
    {
        await InitializeFixtureAsync();

        GlobalFixtureRegistry.RegisterFixture(this);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}