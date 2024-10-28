using Xunit;

namespace FixturesDemo._5.BaseTestsClassImproved;

[CollectionDefinition(nameof(FixtureCollection5))]
public class FixtureCollection5 : ICollectionFixture<Fixture5>
{
}