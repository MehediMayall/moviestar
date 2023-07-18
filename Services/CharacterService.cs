namespace MovieStar.Services
{
    public class CharacterService: ICharacterService
    {
        private readonly CharacterContext context;
        private readonly IMapper mapper;

        public CharacterService(CharacterContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<CharacterDto>> getAll()
        {
            return await this.context.Characters.Select(c=> this.mapper.Map<Character,CharacterDto>(c)).ToListAsync();
        }
    }
}