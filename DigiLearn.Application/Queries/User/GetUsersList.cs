using DigiLearn.Application.DTOs;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.User;

public class GetUsersList : IQuery<IEnumerable<UserDto>>
{
}
