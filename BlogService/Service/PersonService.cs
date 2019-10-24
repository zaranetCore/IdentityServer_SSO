using System;
using System.Collections.Generic;
using System.Text;
using BasicData_DDD.Model;
using BasicData_DDD.Model.Models;
using System.Linq;
using BlogRepository.Repository;

namespace BlogService
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personService;
        public PersonService(IPersonRepository personService)
        {
            _personService = personService;
        }
        public List<PERSON> people()
        {
            return _personService.people();
        }
    }
}
