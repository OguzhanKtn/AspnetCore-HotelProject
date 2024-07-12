using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageCategoryDal : GenericRepository<MessageCategory>, IMessageCategoryDal
    {
        private readonly Context _context;
        public EfMessageCategoryDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<MessageCategory> MessagesByCategory()
        {
           return _context.MessageCategories.Include(x=>x.Contacts).ToList();
        }
    }
}
