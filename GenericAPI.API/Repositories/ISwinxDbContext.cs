using Microsoft.EntityFrameworkCore;
using GenericAPI.APIEntities;

namespace GenericAPI.APIRepositories
{
    public interface ISwinxDbContext
    {
        DbSet<User> Users { get; set; }


    }
}
