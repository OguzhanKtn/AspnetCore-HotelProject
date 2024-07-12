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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        Context _context;
        public EfContactDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetContactCount()
        {
           return _context.Contacts.Count();
        }

        public List<Contact> messageList()
        {
            return _context.Contacts.Include(x=>x.MessageCategory).ToList();
        }
    }
}
