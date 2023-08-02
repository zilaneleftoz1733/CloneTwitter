using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public interface IPostDal : IGenericDal<Posts>
    {
        void Insert(Func<List<Posts>> getPosts);
    }
}