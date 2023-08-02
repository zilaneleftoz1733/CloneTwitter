using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public  class PostManager : IPostService
    {
        IPostDal _postDal;
        public PostManager( IPostDal postDal)
        {
            _postDal = postDal;
        }
        public List<Posts> GetAllList()
        {
            return _postDal.GetListAll();
        }

        public List<Posts> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Posts GetByID(int id)
        {
            return _postDal.GetByID(id);
        }

        public Posts GetById(int id)
        {
            return _postDal.GetByID(id);
        }

        public List<Posts> GetPosts()
        {
            throw new NotImplementedException();
        }

        public void PostAdd(Posts post)
        {
            throw new NotImplementedException();
        }

        public void PostsAdd(Posts post)
        {
            _postDal.Insert(post);
        }

        public void PostsAdd(User user)
        {
            throw new NotImplementedException();
        }

        public void PostsDelete(Posts post)
        {
            _postDal.Delete(post);
        }

        public void PostsDelete(User user)
        {
            throw new NotImplementedException();
        }

        public void PostUpdate(Posts post)
        {
           _postDal.Update(post);
        }

        public void PostUpdate(User user)
        {
            throw new NotImplementedException();
        }

        User IPostService.GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
