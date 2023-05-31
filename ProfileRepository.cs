using Microsoft.EntityFrameworkCore;
using study_docker;

public class ProfileRepository : IProfileRepository
{
    private readonly ProfileContext _context;
    
    public ProfileRepository(ProfileContext context)
    {
        _context = context;
    }
    
    public Task<Student> Get(int id)
    {
        return _context.Students.FirstOrDefaultAsync(student => student.Id == id);
    }

    public Task<List<Student>> Get()
    {
        return _context.Students.ToListAsync();
    }
}