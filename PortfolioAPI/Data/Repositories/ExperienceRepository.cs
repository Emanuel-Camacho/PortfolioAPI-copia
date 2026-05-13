using PortfolioAPI.Data;
using PortfolioAPI.Data.Entities;

namespace PortfolioAPI.Data.Repositories
{
    public class ExperienceRepository
    {
        // 1 - Se declara una variable privada y readonly que almacenará un objeto del tipo ApplicationContext
        private readonly ApplicationContext _context;

        // 2 - El constructor recibe un objeto ApplicationContext mediante inyección de dependencias
        //     y lo asigna a la variable privada _context para poder utilizarlo en toda la clase
        public ExperienceRepository(ApplicationContext context)
        {
            _context = context;
            Console.WriteLine("instanciado");
        }

        // Metodos de la clase ExperienceRepository
        public List<Experience> Get() 
        {
            return _context.Experiences.ToList();
        }

        public List<Experience> Get(string title)
        {
            return _context.Experiences.Where(e => e.Title.Contains(title)).ToList();
        }

        public Experience? Get(int id) 
        {
            return _context.Experiences.FirstOrDefault(e => e.Id == id);
        }

        public int Add(Experience exp)
        {
            _context.Experiences.Add(exp);
            _context.SaveChanges();
            return exp.Id;
        }
    }
}
