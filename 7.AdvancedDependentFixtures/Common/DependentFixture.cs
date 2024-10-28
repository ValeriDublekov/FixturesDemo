using Xunit;

namespace FixturesDemo._7.AdvancedDependentFixtures.Common;

public abstract class DependentFixture<TDependency> : IAsyncLifetime
    where TDependency : AutoRegisteringFixture
{
    public async Task InitializeAsync()
    {
        TDependency dependency = await GlobalFixtureRegistry.GetFixtureAsync<TDependency>();
        await InitializeWithDependencyAsync(dependency);
    }

    protected abstract Task InitializeWithDependencyAsync(TDependency dependency);

    public Task DisposeAsync() => Task.CompletedTask;
}