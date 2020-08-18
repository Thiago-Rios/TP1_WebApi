using Microsoft.EntityFrameworkCore;
using Domain;
using System;

namespace Repository
{
    public class AmigosContext : DbContext
    {
        public DbSet<Amigo> Amigos { get; set; }

        public AmigosContext(DbContextOptions<AmigosContext> options) : base(options)
        {

        }
    }
}
