using System;

namespace MasterSystem.Abstractions;

/// <summary>
/// File name attribute.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public class FileNameAttribute : Attribute
{
    /// <summary>
    /// File name.
    /// </summary>
    public readonly string Name;

    /// <summary>
    /// Initialize a new instance of <see cref="FileNameAttribute"/>.
    /// </summary>
    /// <param name="name">File name.</param>
    public FileNameAttribute(string name) => Name = name;
}