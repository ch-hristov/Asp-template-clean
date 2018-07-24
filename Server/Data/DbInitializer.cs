using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspCoreServer.Models;
using AspCoreServer;

namespace AspCoreServer.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SpaDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            context.SaveChanges();
        }
    }
}
