using Xunit;

namespace FixturesDemo._6.Dependent_fixtures;

[CollectionDefinition(nameof(DBFixtureCollection))]
public class DBFixtureCollection : ICollectionFixture<DBFixture>;