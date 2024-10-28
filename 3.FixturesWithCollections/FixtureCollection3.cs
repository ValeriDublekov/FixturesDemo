using Xunit;

namespace FixturesDemo._3.FixturesWithCollections;

[CollectionDefinition(nameof(FixtureCollection3))]
public class FixtureCollection3 : ICollectionFixture<Fixture3>
{
}