﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PanelKey.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbMyHouseKeyEntities : DbContext
    {
        public dbMyHouseKeyEntities()
            : base("name=dbMyHouseKeyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Key> Tbl_Key { get; set; }
        public virtual DbSet<Tbl_Panel> Tbl_Panel { get; set; }
        public virtual DbSet<Tbl_PanelKey> Tbl_PanelKey { get; set; }
        public virtual DbSet<Tbl_User> Tbl_User { get; set; }
        public virtual DbSet<Tbl_UserKey> Tbl_UserKey { get; set; }
    }
}
