using Xunit;

namespace FixturesDemo._7.Advanced_Dependent_fixtures;

[CollectionDefinition(nameof(DBFixtureFixtureCollection))]
public class DBFixtureFixtureCollection : ICollectionFixture<DBFixture>;