using Xunit;

namespace FixturesDemo._3.Fixtures_with_collections;

[CollectionDefinition(nameof(FixtureCollection3))]
public class FixtureCollection3 : ICollectionFixture<Fixture3>
{
}