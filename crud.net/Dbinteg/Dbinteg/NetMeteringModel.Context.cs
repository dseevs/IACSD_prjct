//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbinteg
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NetmeteringEntities : DbContext
    {
        public NetmeteringEntities()
            : base("name=NetmeteringEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Netmetering> Netmeterings { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
