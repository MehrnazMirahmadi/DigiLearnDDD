using DigiLearn.Domain.Exceptions.UserManagementExceptions;

namespace DigiLearn.Domain.ValueObjects;

public record RoleName
{
    public string Value { get; }
    public RoleName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new RoleNameNullOrEmptyException();
        }


        Value = value;
    }

    public static implicit operator string(RoleName role) => role.Value;
    public static implicit operator RoleName(string role) => new(role);
}
