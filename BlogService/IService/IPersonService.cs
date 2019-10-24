using System;
using System.Collections.Generic;
using System.Text;
using BasicData_DDD.Model.Models;

namespace BlogService
{
    public interface IPersonService
    {
        List<PERSON> people();
    }
}
