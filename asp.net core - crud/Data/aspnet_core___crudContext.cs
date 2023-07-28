using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp.net_core___crud.Model;

namespace asp.net_core___crud.Data
{
    public class aspnet_core___crudContext : DbContext
    {
        public aspnet_core___crudContext (DbContextOptions<aspnet_core___crudContext> options)
            : base(options)
        {
        }

        public DbSet<asp.net_core___crud.Model.User> User { get; set; } = default!;
    }
}
