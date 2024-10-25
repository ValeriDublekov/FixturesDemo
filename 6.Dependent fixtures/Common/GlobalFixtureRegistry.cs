namespace FixturesDemo._6.Dependent_fixtures.Common;

public class GlobalFixtureRegistry
{
    public static TaskCompletionSource<DBFixture> DBFixture { get; } = new();

    public static void RegisterFixture(DBFixture dbFixture)
    {
        DBFixture.SetResult(dbFixture);
    }

    public static Task<DBFixture> GetDBFixtureAsync()
    {
        return DBFixture.Task;
    }
}