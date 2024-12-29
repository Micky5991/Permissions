using CommunityToolkit.Diagnostics;

namespace Permissions.Decision;

public sealed class AccessRequest
{
    /// <summary>
    /// Subject that tries to access a certain <see cref="Resource"/> with the specified <see cref="Action"/>.
    /// </summary>
    public SubjectIdentifier Subject { get; }

    /// <summary>
    /// Resource that will be accessed by the given <see cref="Subject"/>.
    /// </summary>
    public ResourceIdentifier Resource { get; }

    /// <summary>
    /// Action that will be applied to the specified <see cref="Resource"/> by the <see cref="Subject"/>.
    /// </summary>
    public ResourceAction Action { get; }

    /// <summary>
    /// Extra environment data of this access request.
    /// </summary>
    public Dictionary<string, object> Context { get; set; }

    public AccessRequest(SubjectIdentifier subject, ResourceIdentifier resource, ResourceAction action, Dictionary<string, object>? context = null)
    {
        Guard.IsNotNull(subject);
        Guard.IsNotNull(resource);
        Guard.IsNotNull(action);

        Subject = subject;
        Resource = resource;
        Action = action;

        Context = context ?? new Dictionary<string, object>();
    }
}