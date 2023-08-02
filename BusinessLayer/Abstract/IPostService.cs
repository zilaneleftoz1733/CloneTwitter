using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPostService
    {

        void PostAdd(Posts post);
        List<Posts> GetAllPosts();
        void PostsAdd(Posts post);
        void PostsDelete(Posts post);
        void PostUpdate(Posts post);
        List<Posts> GetAllList();
        User GetByID(int id);
        List<Posts> GetPosts();
        Posts GetById(int id);

    }
}
