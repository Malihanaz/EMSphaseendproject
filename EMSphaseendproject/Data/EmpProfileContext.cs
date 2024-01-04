using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSphaseendproject.Models;

namespace EMSphaseendproject.Data
{
    public class EmpProfileContext : DbContext
    {
        public EmpProfileContext (DbContextOptions<EmpProfileContext> options)
            : base(options)
        {
        }

        public DbSet<EMSphaseendproject.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
