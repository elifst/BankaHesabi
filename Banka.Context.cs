﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaHesaplari.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BankaHesaplariEntities : DbContext
    {
        public BankaHesaplariEntities()
            : base("name=BankaHesaplariEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HesapHareketleri> HesapHareketleri { get; set; }
        public virtual DbSet<Hesaplar> Hesaplar { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
    }
}
