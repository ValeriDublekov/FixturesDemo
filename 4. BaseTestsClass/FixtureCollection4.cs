using Xunit;

namespace FixturesDemo._4._BaseTestsClass;

[CollectionDefinition(nameof(FixtureCollection4))]
public class FixtureCollection4 : ICollectionFixture<Fixture4>
{
}