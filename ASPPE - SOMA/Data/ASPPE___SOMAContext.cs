using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPPE___SOMA.Models;

namespace ASPPE___SOMA.Data
{
    public class ASPPE___SOMAContext : DbContext
    {
        public ASPPE___SOMAContext (DbContextOptions<ASPPE___SOMAContext> options)
            : base(options)
        {
        }

        public DbSet<Equipes> Equipes { get; set; } = default!;
    }
}
