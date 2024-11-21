using Xunit;

namespace FixturesDemo._7.AdvancedDependentFixtures.Common;

public abstract class AutoRegisteringFixture : IAsyncLifetime
{
    protected abstract Task InitializeFixtureAsync();

    public async Task InitializeAsync()
    {
        try
        {
            await InitializeFixtureAsync();
        }
        catch (Exception e)
        {
            GlobalFixtureRegistry.SetFailure(this, e);
        }

        GlobalFixtureRegistry.RegisterFixture(this);
    }

    public Task DisposeAsync() => Task.CompletedTask;
}