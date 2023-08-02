using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUsersService
    {
        void UserAdd(User user);
        void UserDelete(User user);
        void UserUpdate(User user);
        List<User> GetAllList();
        User GetByID(int id);
        List<Posts> GetPosts();
        Posts GetById(int id);
    }
}
