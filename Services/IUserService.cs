namespace MovieStar.Services
{
    public interface IUserService{
        Task<User> registerUser(UserAddDto NewUser);
    }
}