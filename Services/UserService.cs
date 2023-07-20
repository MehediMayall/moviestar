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
            // Checking if user already exists
            if(await this.repo.getUserByEmail(NewUser.Email) !=null) throw new Exception($"An user already exist with this email id -> {NewUser.Email}. Please select different email."); 

             User newUser =  this.mapper.Map<User>(NewUser);
             
             new Security().createPasswordHash(NewUser.Password, out byte[]PasswordHash, out byte[] PasswordSalt );
             newUser.PasswordSalt = PasswordSalt;
             newUser.PasswordHash = PasswordHash;

             return this.mapper.Map<UserDto>( await this.repo.save(newUser));
        }


    }
}