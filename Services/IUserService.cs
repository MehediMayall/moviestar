namespace MovieStar.Services
{
    public interface IUserService{
        Task<User> RegisterUser(UserAddDto NewUser);
    }
}