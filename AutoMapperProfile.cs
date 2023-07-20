namespace MovieStar
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Character
            CreateMap<CharacterDto, Character>();
            CreateMap<Character, CharacterDto>();
            CreateMap<CharacterAddDto, Character>();

            // User
            CreateMap<UserAddDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}