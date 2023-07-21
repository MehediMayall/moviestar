namespace MovieStar.Services
{
    public interface IUserService{
        Task<UserDto> RegisterUser(UserAddDto NewUser);
        Task<LoginResponseDto> AuthenticateUser(LoginDto loginDto);
    }
}