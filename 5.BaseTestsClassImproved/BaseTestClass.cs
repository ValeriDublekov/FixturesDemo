using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._5.BaseTestsClassImproved;

[Collection(nameof(FixtureCollection5))]
public class BaseTestClass
{
    protected Fixture5 Fixture { get; }

    public BaseTestClass()
    {
        Fixture = Fixture5.Instance;
        Logger.Log();
    }
}