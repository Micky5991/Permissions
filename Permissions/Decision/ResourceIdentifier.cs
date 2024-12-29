using System.Text.RegularExpressions;

using CommunityToolkit.Diagnostics;

namespace Permissions.Decision;

/// <summary>
/// Identifier for any resource that a subject wants to have access to.
/// </summary>
public sealed class ResourceIdentifier
{
    public string Type { get; }
    public string Id { get; }

    public ResourceIdentifier(string type, string id)
    {
        Guard.IsNotNullOrEmpty(type);
        Guard.IsNotNullOrEmpty(id);

        Type = type;
        Id = id;
    }

    public override string ToString()
    {
        return $"{Type}/{Id}";
    }
}