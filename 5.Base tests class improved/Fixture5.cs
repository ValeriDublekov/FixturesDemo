﻿using FixturesDemo.Logging;

namespace FixturesDemo._5.Base_tests_class_improved;

public class Fixture5
{
    public static Fixture5 Instance { get; private set; } = null!;

    public Fixture5()
    {
        Logger.Log();
        Instance = this;
    }
}