using MovieStar.Library;
using MovieStar.Repositories;

namespace MovieStar.Services
{
    public class UserService: IUserService
    {
        private readonly CharacterContext context;
        private readonly IMapper mapper;
        private readonly UserRepository repo;
        public UserService(CharacterContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
            this.repo = new UserRepository(context);
        }


        public async Task<UserDto> RegisterUser(UserAddDto NewUser)
        {
             User newUser =  this.mapper.Map<User>(NewUser);
             
             new Security().createPasswordHash(NewUser.Password, out byte[]PasswordHash, out byte[] PasswordSalt );
             newUser.PasswordSalt = PasswordSalt;
             newUser.PasswordHash = PasswordHash;

             return this.mapper.Map<UserDto>( await this.repo.save(newUser));
        }


    }
}