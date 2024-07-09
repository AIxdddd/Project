using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.persistance
{
    public class DbInitializer
    {
        public static void Initialize(ProjectsDbContext context)
        {
            context.Database.EnsureCreated();
        }

    }
}
