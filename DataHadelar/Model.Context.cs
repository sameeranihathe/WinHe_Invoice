﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataHadelar
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class WinheProjectEntities : DbContext
    {
        public WinheProjectEntities()
            : base("name=WinheProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CustomersDetail> CustomersDetails { get; set; }
        public DbSet<InvoiceHeaderDetail> InvoiceHeaderDetails { get; set; }
        public DbSet<InvoiceLineDetail> InvoiceLineDetails { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    
        public virtual ObjectResult<Proc_GetCustomers_Result> Proc_GetCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetCustomers_Result>("Proc_GetCustomers");
        }
    
        public virtual ObjectResult<Proc_Getdata_Result> Proc_Getdata()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_Getdata_Result>("Proc_Getdata");
        }
    
        public virtual ObjectResult<Proc_GetInvoiceData_Result> Proc_GetInvoiceData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetInvoiceData_Result>("Proc_GetInvoiceData");
        }
    
        public virtual ObjectResult<Proc_GetInvoiceData2_Result> Proc_GetInvoiceData2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetInvoiceData2_Result>("Proc_GetInvoiceData2");
        }
    
        public virtual ObjectResult<Proc_GetProducts_Result> Proc_GetProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_GetProducts_Result>("Proc_GetProducts");
        }
    
        public virtual ObjectResult<PROC_invo_Result> PROC_invo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_invo_Result>("PROC_invo");
        }
    }
}
