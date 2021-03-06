﻿using System.Data.Entity;
using GenRepo.Client.Model.Mappings;

namespace GenRepo.Client.EFDbContext
{
    public class NotSoScalableDbContext :DbContext
    {
        public NotSoScalableDbContext(string connectionName)
            : base(connectionName)
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductEntityConfiguration());
            modelBuilder.Configurations.Add(new BrandEntityConfiguration());
            
            //Add entity configuration for more entity
        }
    }
}