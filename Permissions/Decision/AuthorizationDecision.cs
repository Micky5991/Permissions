namespace Permissions.Decision;

public enum AuthorizationDecision
{
    /// <summary>
    /// Denies access to this resource action fully.
    /// </summary>
    Deny,

    /// <summary>
    /// Denies access to this resource action fully, but this can be used to still allow the user to see the existence of this action.
    /// </summary>
    Disable,

    /// <summary>
    /// Grants full access to this resource action.
    /// </summary>
    Allow,
}