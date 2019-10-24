using BasicData_DDD.Model.Models;
using BlogRepository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlogRepository.IRepository
{
    public class PersonRepository : IPersonRepository
    {
        BlogDbContext db = new BlogDbContext();
        public List<PERSON> people()
        {
            return db.PERSON.ToList();
        }
    }
}
