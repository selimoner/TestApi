using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Domain.Entities;

namespace TestApi.Persistence.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            Store store1 = new()
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Name="Migros",
                Priorty=1
            };
            Store store2 = new()
            {
                Id=2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Name="Anpa Gross",
                Priorty=2
            };
            Store store3 = new()
            {
                Id = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
                Name = "Happy Center",
                Priorty = 3
            };
            builder.HasData(store1, store2, store3);
        }
    }
}
