using DigiLearn.Application.DTOs;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.User;

public class GetUserById : IQuery<UserDto>
{
    public Guid Id { get; set; }
}
