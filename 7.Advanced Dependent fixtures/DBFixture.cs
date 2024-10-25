using FixturesDemo._7.Advanced_Dependent_fixtures.Common;
using FixturesDemo.Logging;

namespace FixturesDemo._7.Advanced_Dependent_fixtures;

public class DBFixture : AutoRegisteringFixture
{
    protected override async Task InitializeFixtureAsync()
    {
        await Task.Delay(TimeSpan.FromMilliseconds(500));
        Logger.Log();
    }
}