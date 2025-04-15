using WebApplication2.Dtos;

namespace WebApplication2.Services.Interface
{
    public interface IUserService
    {
        void AddUser(InsertUserDto userDto);

        List<GetAllUserDto> GetAllUsers();
        GetAllUserDto GetUserById(Guid id);
        void DeleteUser(Guid id);
        void UpdateUser(Guid id,UpdateUserDto userDto);

    }
}
