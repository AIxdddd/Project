using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
    }
}
