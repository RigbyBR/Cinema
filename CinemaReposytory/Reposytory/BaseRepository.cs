using CinemaDomain.Base;
using CinemaReposytory.Base;
using CinemaReposytory.Context;
using Microsoft.EntityFrameworkCore;

namespace CinemaReposytory.Reposytory
{
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyBDContext _myDBContext;

        public BaseRepository(MyBDContext myDBContext)
        {
            _myDBContext = myDBContext;
            _myDBContext.Set<TypeEntity>();
        }

        public void Create(object entity)
        {
            _myDBContext.Add(entity);
            _myDBContext.SaveChanges();
        }

        public TypeEntity ReadbyId(int id)
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList().Find(x => x.id == id);
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList();
        }

        public void Update(TypeEntity entity)
        {
            _myDBContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _myDBContext.SaveChanges();
        }
        public void Delete(int id)
        {
            _myDBContext.Remove(ReadbyId(id));
            _myDBContext.SaveChanges();
        }
    }
}
