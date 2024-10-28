using FixturesDemo._7.AdvancedDependentFixtures.Common;
using FixturesDemo.Logging;

namespace FixturesDemo._7.AdvancedDependentFixtures;

public class DBFixture : AutoRegisteringFixture
{
    protected override async Task InitializeFixtureAsync()
    {
        await Task.Delay(TimeSpan.FromMilliseconds(500));
        Logger.Log();
    }
}