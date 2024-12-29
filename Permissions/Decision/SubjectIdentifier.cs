using CommunityToolkit.Diagnostics;

namespace Permissions.Decision;

public sealed class SubjectIdentifier
{
    public string Type { get; }
    public string Id { get; }

    public SubjectIdentifier(string type, string id)
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