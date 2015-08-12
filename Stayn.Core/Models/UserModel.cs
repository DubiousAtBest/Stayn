using System;
using System.Collections.Generic;
using System.Text;

namespace Stayn.Core.Models
{
    public abstract class UserModel
    {
        public virtual string Username { get; set; }
        public virtual DateTime Joined { get; set; }
        public virtual string SessionKey { get; set; }
        public abstract UserRole Role { get; set; }
    }
}
