using DeepLom.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepLom.Data
{
    public class DeepContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
