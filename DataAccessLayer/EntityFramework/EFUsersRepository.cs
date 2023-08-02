using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPostRepository : GenericRepository<Posts>, IPostDal
    {
        public void Insert(Func<List<Posts>> getPosts)
        {
            throw new NotImplementedException();
        }
    }
}
