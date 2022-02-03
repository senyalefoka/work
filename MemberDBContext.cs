using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WORKING_PRJT.Shared.Models;

namespace WORKING_PRJT.Server.Data
{
    public class MemberDBContext : DbContext
    {
        public MemberDBContext(DbContextOptions<MemberDBContext> options) : base(options)
        {
        }
        public DbSet<Developer> Members { get; set; }
    }
}

