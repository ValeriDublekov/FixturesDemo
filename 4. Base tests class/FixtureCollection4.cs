using Xunit;

namespace FixturesDemo._4._Base_tests_class;

[CollectionDefinition(nameof(FixtureCollection4))]
public class FixtureCollection4 : ICollectionFixture<Fixture4>
{
}