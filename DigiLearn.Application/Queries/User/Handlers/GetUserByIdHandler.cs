using DigiLearn.Application.DTOs;
using DigiLearn.Application.Services;
using DigiLearn.Shared.Abstraction.Queries;

namespace DigiLearn.Application.Queries.User.Handlers;

public class GetUserByIdHandler : IQueryHandler<GetUserById, UserDto>
{
    private readonly IUserReadModelService _readService;

    public GetUserByIdHandler(IUserReadModelService readService)
    {
        _readService = readService;
    }

    public async Task<UserDto> HandleAsync(GetUserById query)
    {
        return (await _readService
            .GetUserById(query.Id))
            .ToDto();
    }
}
