using System;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Returns true if obj is an int, otherwise false</summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if obj is an int</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}