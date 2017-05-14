using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionRepositories.Entities;

namespace DependencyInjectionRepositories.Interfaces
{
    public interface IPeopleRepository
    {
        List<Person> GetPeople();
    }
}
