﻿using System;
namespace Praktika5
{
    public class BrainAttribute : Attribute
    {
        public int MinimumValue { get; private set; }

        public BrainAttribute(int min)
        {
            MinimumValue = min;
        }
    }

    public class MonsterTypeAttribute : Attribute
    {
        public MonsterType[] ValidTypes { get; private set; }

        public MonsterTypeAttribute(params MonsterType[] types)
        {
            ValidTypes = types;
        }
    }
}