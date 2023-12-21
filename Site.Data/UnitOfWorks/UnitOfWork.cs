using Namespace;
using Site.Data.Repositories.Abstractions;
using Site.Data.Repositories.Concretes;


namespace Site.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbcontext;

        public UnitOfWork(AppDbContext dbcontext) 
        {
            this.dbcontext = dbcontext;
        }
        public async ValueTask DisposeAsync()
        {
           await dbcontext.DisposeAsync();
        }

        public int Save()
        {
          return dbcontext.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
           return dbcontext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
           return new Repository<T>(dbcontext);
        }
    }
}
