using PlatformService.Models;

namespace PlatformService.Data;

public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext _context;

    public PlatformRepo(AppDbContext context)
    {
        _context = context;
    }

    public bool SaveChanges() => (_context.SaveChanges() >= 0);

    public IEnumerable<Platform> GetAllPlatforms() => _context.Platforms.ToList();

    public Platform? GetPlatformById(int platformId) => _context.Platforms.FirstOrDefault(p => p.Id == platformId);

    public void CreatePlatform(Platform platform)
    {
        if (platform is null) throw new ArgumentNullException(nameof(platform));
        _context.Platforms.Add(platform);
    }
}