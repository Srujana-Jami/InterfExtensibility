using Microsoft.EntityFrameworkCore;
using PersonRepositoty.Interface;

using System.Collections.Generic;
using System.Linq;


namespace PeopleService.SQL
{
    public class SQLRepository : IPersonReader
    {
        private readonly DbContextOptions<PersonContext> _options;

        public SQLRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonContext>();
            optionsBuilder.UseSqlite("Data Source=People.db");
            _options = optionsBuilder.Options;
        }

        public IEnumerable<Person> GetPeople()
        {
            using (var context = new PersonContext(_options))
            {
                return context.People.ToArray();
            }
        }

        public Person GetPerson(int id)
        {
            using (var context = new PersonContext(_options))
            {
                return context.People.Where(p => p.Id == id).FirstOrDefault();
            }
        }
    }
}
