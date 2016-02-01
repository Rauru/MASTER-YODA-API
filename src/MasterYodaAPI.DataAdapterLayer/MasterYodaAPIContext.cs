using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterYodaAPI.DataAdapterLayer
{
    public class MasterYodaAPIContext : DbContext
    {
        public MasterYodaAPIContext() : base("name=yodamasterDB")
        {
            
        }
        public DbSet<User> Users { get; set; }

    }
}
