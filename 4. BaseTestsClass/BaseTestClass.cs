using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._4._BaseTestsClass;

[Collection(nameof(FixtureCollection4))]
public class BaseTestClass : IDisposable
{
    private readonly Fixture4 _fixture;
    private readonly DbContextTransaction _dbContextTransaction;

    public BaseTestClass(Fixture4 fixture)
    {
        _fixture = fixture;
        _dbContextTransaction = _fixture.BeginTransaction();
        Logger.Log();
    }

    public void Dispose()
    {
        _fixture.RollbackTransaction(_dbContextTransaction);
    }
}