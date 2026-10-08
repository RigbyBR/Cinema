using CinemaDomain.Base;

namespace CinemaReposytory.Base
{
    public interface IBaseRepository<TypeEntity> where TypeEntity : IBaseEntity 
    {
        void Create(object entity);
        TypeEntity ReadbyId(int id);
        IList<TypeEntity> ReadAll();
        void Update(TypeEntity entity);
        void Delete(int id);
    }
}

