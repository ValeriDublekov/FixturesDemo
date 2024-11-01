﻿using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._2.FixturesWithoutCollections;

public class TestClassA : IClassFixture<Fixture1>
{
    private readonly Fixture1 _fixture;

    public TestClassA(Fixture1 fixture)
    {
        _fixture = fixture;
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }

    [Fact]
    public void Test_2()
    {
        Logger.Log();
    }
}