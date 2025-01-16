using Microsoft.EntityFrameworkCore;
using WebApiPerson.Data.Entities;
using WebApiPerson.Data.DbContexts;

namespace WebApiPerson.Data.DbContexts
{
    public class PersonApiContext: DbContext
    {
        public PersonApiContext(DbContextOptions<PersonApiContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}
