﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Equals]
public struct CustomStructEquals
{
    [IgnoreDuringEquals]
    public int X { get; set; }

    [CustomEqualsInternal]
    private bool Custom(CustomStructEquals other)
    {
        return X == 1 && other.X == 2 || X == 2 && other.X == 1;
    }
}

[Equals]
public struct CustomGenericEquals<T>
{
    [IgnoreDuringEquals]
    public T Prop { get; set; }

    [CustomEqualsInternal]
    private bool Custom(CustomGenericEquals<T> other)
    {
        return object.Equals(Prop, other.Prop);
    }
}

[Equals]
public class CustomEquals
{
    [IgnoreDuringEquals]
    public int X { get; set; }

    [CustomEqualsInternal]
    private bool Custom(CustomEquals other)
    {
        return X == 1 && other.X == 2 || X == 2 && other.X == 1;
    }
}