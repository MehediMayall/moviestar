namespace MovieStar.Services;

public class CharacterService: BaseService, ICharacterService
{
    private readonly CharacterContext context;
    private readonly IMapper mapper;
    private readonly IHttpContextAccessor httpContext;

    public CharacterService(CharacterContext context, IMapper mapper, IHttpContextAccessor httpContext): base(httpContext)
    {
        this.context = context;
        this.mapper = mapper;
        this.httpContext = httpContext;
    }

    public async Task<List<CharacterDto>> getAll()
    {
        return await this.context.Characters.Where(c=> c.CreatedByID == sessionUser.Id).Select(c=> this.mapper.Map<Character,CharacterDto>(c)).ToListAsync();
    }

    public async Task<CharacterDto> save(CharacterAddDto NewCharacter)
    {
        var newCharacter = this.mapper.Map<Character>(NewCharacter);
        await this.context.Characters.AddAsync(newCharacter);
        await this.context.SaveChangesAsync();            
        return this.mapper.Map<CharacterDto>(newCharacter);
    }
}
