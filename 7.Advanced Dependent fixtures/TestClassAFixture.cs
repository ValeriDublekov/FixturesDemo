using FixturesDemo._7.Advanced_Dependent_fixtures.Common;
using FixturesDemo.Logging;

namespace FixturesDemo._7.Advanced_Dependent_fixtures;

public class TestClassAFixture : DependentFixture<DBFixture>
{
    private DBFixture _dbFixture = null!;

    protected override async Task InitializeWithDependencyAsync(DBFixture dependency)
    {
        Logger.Log();
        _dbFixture = dependency;
    }
}