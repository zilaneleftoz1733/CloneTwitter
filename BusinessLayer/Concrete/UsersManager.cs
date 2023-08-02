using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UsersManager : IUsersService
        {
            IUserDal _userDal;
            public UsersManager(IUserDal userDal)
            {
                _userDal = userDal;
            }

            public List<User> GetAllList()
            {
                return _userDal.GetListAll();
            }

            public User GetByID(int id)
            {
                return _userDal.GetByID(id);
            }

            public Posts GetById(int id)
            {
            throw new NotImplementedException();
             }

        public List<Posts> GetPosts()
        {
            throw new NotImplementedException();
        }

        // public List<Posts> GetPosts()
        //  {
        //throw new NotImplementedException();
        //  }

        public void UserAdd(User user)
            {
                _userDal.Insert(user);
            }

            public void UserDelete(User user)
            {
                _userDal.Delete(user);
            }

            public void UserUpdate(User user)
            {
                _userDal.Update(user);
            }

            //public User GetUserByUsername(User user)
            //{
            //    var currentUser = _userDal.GetListAll().Find(x => x.UserName == user.UserName);
            //    return currentUser;
            //}
    }
}



