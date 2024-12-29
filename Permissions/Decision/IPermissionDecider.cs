namespace Permissions.Decision;

/// <summary>
/// Main logic evaluator and decider for incoming requests. This instance finally decides if the requested access is granted or not.
/// </summary>
/// <remarks>This type represents the PDP (Policy Decision Point) in the ABAC architecture.</remarks>
public interface IPermissionDecider
{
    public Task<AuthorizationDecision> AuthorizeAsync(AccessRequest request);
}