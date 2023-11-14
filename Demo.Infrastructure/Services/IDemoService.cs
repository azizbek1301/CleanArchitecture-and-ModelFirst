namespace Demo.Infrastructure.Services
{
    public interface IDemoService
    {
        public ValueTask<IEnumerable<User>> GetAllUsersAsync();
    }
}
