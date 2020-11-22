using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additonal Namespace
using System.Data.Entity;
using StarTed.Entities;

#endregion


namespace StarTed.DAL
{
    internal class StarTedContext : DbContext
    {
        public StarTedContext():base("StarTED")
        {

        }
        public DbSet<Clubs> Clubs { get; set; }
    }
}
