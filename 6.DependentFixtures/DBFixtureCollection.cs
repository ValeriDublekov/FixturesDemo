using Xunit;

namespace FixturesDemo._6.DependentFixtures;

[CollectionDefinition(nameof(DBFixtureCollection))]
public class DBFixtureCollection : ICollectionFixture<DBFixture>;