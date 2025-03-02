using DigiLearn.Domain.DomainEvents;
using DigiLearn.Domain.ValueObjects;
using DigiLearn.Shared.Abstraction.Domain;

namespace DigiLearn.Domain.Entities.UserManagement;

public class User : AggregateRoot<BaseId>
{
    private Username _userName;
    private Password _password;
    private Email _email;
    private bool _isConfirmed;
    private LinkedList<UserRole> _userRoles;
    internal User(BaseId id, Username userName, Password password, Email email, bool isConfirmed)
    {
        Id = id;
        _userName = userName;
        _password = password;
        _email = email;
        _isConfirmed = isConfirmed;
        RaiseDomainEvent(new UserRegisteredEvent(this));
    }

    public User()
    {

    }
}
