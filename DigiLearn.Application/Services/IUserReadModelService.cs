using DigiLearn.Application.Models.UserManagement;

namespace DigiLearn.Application.Services;


public interface IUserReadModelService
{
    Task<bool> IsUserExistsByEmail(string email);
    Task<UserReadModel> GetUserById(Guid id);
    Task<IEnumerable<UserReadModel>> GetUsers();
}
