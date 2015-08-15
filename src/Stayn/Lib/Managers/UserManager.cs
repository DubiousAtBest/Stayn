using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stayn.Models;

namespace Stayn.Lib.Managers
{
    public class UserManager : IDataManager<ApplicationUser>
    {
        public ApplicationUser[] Data
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(ApplicationUser value)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Find(Predicate<ApplicationUser> value)
        {
            throw new NotImplementedException();
        }

        public void Persist()
        {
            throw new NotImplementedException();
        }

        public void Remove(Predicate<ApplicationUser> value)
        {
            throw new NotImplementedException();
        }

        public void Remove(ApplicationUser value)
        {
            throw new NotImplementedException();
        }
    }
}
