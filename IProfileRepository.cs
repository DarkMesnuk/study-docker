public interface IProfileRepository
{
    Task<Student> Get(int id);
    Task<List<Student>> Get();
}