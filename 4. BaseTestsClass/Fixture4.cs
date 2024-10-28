using FixturesDemo.Logging;

namespace FixturesDemo._4._BaseTestsClass;

public class Fixture4
{
    public Fixture4()
    {
        //_context = new DbContext(new DbContextOptionsBuilder().Options);
        Logger.Log();
    }

    public DbContextTransaction BeginTransaction()
    {
        Logger.Log();
        //return _context.Database.BeginTransaction();
        return new DbContextTransaction();
    }

    public void RollbackTransaction(DbContextTransaction transaction)
    {
        //_context.Database.RollbackTransaction(transaction);
        Logger.Log();
    }
}

public record DbContextTransaction();