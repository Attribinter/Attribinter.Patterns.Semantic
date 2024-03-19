﻿namespace Attribinter;

using System;

[AttributeUsage(AttributeTargets.Class)]
public sealed class NonNullableArrayAttribute : Attribute
{
    public object[] Value { get; }

    public NonNullableArrayAttribute(object[] value)
    {
        Value = value;
    }
}
