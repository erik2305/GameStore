﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CVGS_Tables : DbContext
    {
        public CVGS_Tables()
            : base("name=CVGS_Tables")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AttendeeList> AttendeeLists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePayCategory> EmployeePayCategories { get; set; }
        public virtual DbSet<EmployeePosition> EmployeePositions { get; set; }
        public virtual DbSet<EsrbContentDescriptor> EsrbContentDescriptors { get; set; }
        public virtual DbSet<EsrbRating> EsrbRatings { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventLog> EventLogs { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameCategory> GameCategories { get; set; }
        public virtual DbSet<GameCompany> GameCompanies { get; set; }
        public virtual DbSet<GameEsrbContentDescriptor> GameEsrbContentDescriptors { get; set; }
        public virtual DbSet<GamePerspective> GamePerspectives { get; set; }
        public virtual DbSet<GameStatu> GameStatus { get; set; }
        public virtual DbSet<GameSubCategory> GameSubCategories { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<Population> Populations { get; set; }
        public virtual DbSet<PopulationClassification> PopulationClassifications { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierContact> SupplierContacts { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
        public virtual DbSet<Sku> Skus { get; set; }
    }
}
