﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC1_EntityFramework_Demo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EC1_eStoreEntities : DbContext
    {
        public EC1_eStoreEntities()
            : base("name=EC1_eStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CartInfo> CartInfoes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int spAddProductToCart(Nullable<int> orderID, Nullable<int> productID, Nullable<int> quantity)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("orderID", orderID) :
                new ObjectParameter("orderID", typeof(int));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddProductToCart", orderIDParameter, productIDParameter, quantityParameter);
        }
    }
}
