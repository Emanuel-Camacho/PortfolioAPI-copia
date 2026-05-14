using PortfolioAPI.Data.Entities;

namespace PortfolioAPI.Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> Get()
        {
            return _context.Users.ToList();
        }

        public User? Authenticate(string username, string password)
        {
            // User? significa que puede ser null
            // FirstOrDefault es el encargado de traer todas las propiedades si es que encontro un usuario sino devuelve null
            User? userToAuthenticate = _context.Users.FirstOrDefault(u  => u.Username == username && u.Password == password);
            return userToAuthenticate;
        }

    }
}
