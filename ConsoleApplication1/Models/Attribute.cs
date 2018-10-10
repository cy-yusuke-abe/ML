using System;

namespace TestMachineLearning.Models
{
    [Flags]
    public enum Attribute
    {
        None = 0,
        Fire = 1 << 0,
        Wind = 1 << 1,
        Water = 1 << 2,
        Earth = 1 << 3,
        Light = 1 << 4,
        Darkness = 1 << 5
    }
}