namespace MovieStar.Services
{
    public interface IUserService{
        Task<UserDto> RegisterUser(UserAddDto NewUser);
        Task<UserDto> AuthenticateUser(LoginDto loginDto);
    }
}