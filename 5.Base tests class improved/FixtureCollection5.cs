using Xunit;

namespace FixturesDemo._5.Base_tests_class_improved;

[CollectionDefinition(nameof(FixtureCollection5))]
public class FixtureCollection5 : ICollectionFixture<Fixture5>
{
}