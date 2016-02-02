using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterYodaAPI.DataAdapterLayer.Models;

namespace MasterYodaAPI.DataAdapterLayer
{
    public class MasterYodaAPIContext : DbContext
    {
        public MasterYodaAPIContext() : base("name=LocalyodamasterDB")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Carrera> Carreras { get; set; }

    }
}
