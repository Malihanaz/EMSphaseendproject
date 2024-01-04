using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSphaseendproject.Models;

namespace EMSphaseendproject.Data
{
    public class DeptMasterContext : DbContext
    {
        public DeptMasterContext (DbContextOptions<DeptMasterContext> options)
            : base(options)
        {
        }

        public DbSet<EMSphaseendproject.Models.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
