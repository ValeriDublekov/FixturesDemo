using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._5.Base_tests_class_improved;

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