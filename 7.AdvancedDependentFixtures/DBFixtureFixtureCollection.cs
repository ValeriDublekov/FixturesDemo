using Xunit;

namespace FixturesDemo._7.AdvancedDependentFixtures;

[CollectionDefinition(nameof(DBFixtureFixtureCollection))]
public class DBFixtureFixtureCollection : ICollectionFixture<DBFixture>;