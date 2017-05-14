using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionRepositories;
using DependencyInjectionRepositories.Interfaces;
using Microsoft.Practices.Unity;

namespace DependencyInjectionUnity
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IPeopleRepository, PeopleRepository>();
        }
    }
}
