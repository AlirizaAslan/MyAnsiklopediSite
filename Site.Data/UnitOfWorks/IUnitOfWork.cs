using Site.Core.Entities;
using Site.Data.Repositories.Abstractions;


namespace Site.Data.UnitOfWorks
{
    public interface IUnitOfWork :IAsyncDisposable
    { //genel hal getirdik T ile erişim
        IRepository<T> GetRepository<T>()where T : class,IEntityBase,new();


        Task<int> SaveAsync();
        int Save();


    }
}
