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


        public async Task<User> registerUser(UserAddDto NewUser)
        {
             User newUser =  this.mapper.Map<User>(NewUser);
             byte[] PasswordHash, PasswordSalt;
             
             new Security().createPasswordHash(NewUser.Password, out PasswordHash, out  PasswordSalt );
             newUser.PasswordSalt = PasswordSalt;
             newUser.PasswordHash = PasswordHash;

             return await this.repo.save(newUser);
        }


    }
}