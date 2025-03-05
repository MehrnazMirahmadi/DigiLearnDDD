using DigiLearn.Application.DTOs;
using DigiLearn.Application.Services;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.User.Handlers;

public class GetUsersListHandler : IQueryHandler<GetUsersList, IEnumerable<UserDto>>
{
    private readonly IUserReadModelService _readService;

    public GetUsersListHandler(IUserReadModelService readService)
    {
        _readService = readService;
    }

    public async Task<IEnumerable<UserDto>> HandleAsync(GetUsersList query)
    {
        return (await _readService.GetUsers())
            .Select(u => u.ToDto())
            .ToList();
    }
}

