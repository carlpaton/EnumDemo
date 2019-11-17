﻿using System;

namespace EnumDemo.Enum
{
    [Flags]
    public enum Days
    {
        None = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64
    }
}
