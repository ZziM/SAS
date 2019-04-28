using SAS.Model;

namespace SAS.Repository.Repository.Abstract
{
    public abstract class BaseRepository
    {
        protected readonly SecurityAreaSystemContext _db;

        protected BaseRepository(SecurityAreaSystemContext db)
        {
            this._db = db;
        }
    }
}