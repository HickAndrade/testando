using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Persistences
{
    public class LojaContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }


        public LojaContext(DbContextOptions options): base(options)
        {

        }

    }
}
