using BasicData_DDD.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogRepository.Repository
{
    public interface IPersonRepository
    {
        List<PERSON> people();
    }
}
