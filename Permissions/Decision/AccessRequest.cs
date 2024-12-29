using CommunityToolkit.Diagnostics;

namespace Permissions.Decision;

public sealed class AccessRequest
{
    public SubjectIdentifier Subject { get; }
    public ResourceIdentifier Resource { get; }
    public ResourceAction Action { get; }

    public AccessRequest(SubjectIdentifier subject, ResourceIdentifier resource, ResourceAction action)
    {
        Guard.IsNotNull(subject);
        Guard.IsNotNull(resource);
        Guard.IsNotNull(action);

        Subject = subject;
        Resource = resource;
        Action = action;
    }
}