namespace MovieStar
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CharacterDto, Character>();
            CreateMap<Character, CharacterDto>();
        }
    }
}