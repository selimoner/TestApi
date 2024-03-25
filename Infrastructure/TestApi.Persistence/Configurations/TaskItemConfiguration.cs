using Bogus;
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
    public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            Faker faker = new();
            TaskItem taskItem1 = new()
            {
                StoreId = 1,
                CreatedDate = DateTime.Now,
                Id = 1,
                IsDeleted = false,
                Quantity = "5 pcs",
                Description = faker.Lorem.Sentence(5),
                IsCompleted = false,
            };
            TaskItem taskItem2 = new()
            {
                StoreId = 2,
                CreatedDate = DateTime.Now,
                Id = 2,
                IsDeleted = false,
                Quantity = "500 gr.",
                Description = faker.Lorem.Sentence(5),
                IsCompleted = false,
            };
            TaskItem taskItem3 = new()
            {
                StoreId = 1,
                CreatedDate = DateTime.Now,
                Id = 3,
                IsDeleted = true,
                Quantity = "1 kg.",
                Description = faker.Lorem.Sentence(5),
                IsCompleted = false,
            };
            builder.HasData(taskItem1, taskItem2, taskItem3);   
        }
    }
}
