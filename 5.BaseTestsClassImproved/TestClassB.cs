﻿using FixturesDemo.Logging;
using Xunit;

namespace FixturesDemo._5.BaseTestsClassImproved;

public class TestClassB : BaseTestClass
{
    public TestClassB()
    {
        Logger.Log();
    }

    [Fact]
    public void Test_1()
    {
        Logger.Log();
    }
}