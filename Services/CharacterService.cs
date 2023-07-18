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

        public async Task<CharacterDto> save(CharacterAddDto NewCharacter)
        {
            var newCharacter = this.mapper.Map<Character>(NewCharacter);
            await this.context.Characters.AddAsync(newCharacter);
            await this.context.SaveChangesAsync();            
            return this.mapper.Map<CharacterDto>(newCharacter);
        }
    }
}