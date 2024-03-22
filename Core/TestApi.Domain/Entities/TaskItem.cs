using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Domain.Common;

namespace TestApi.Domain.Entities
{
    public class TaskItem:EntityBase
    {
        public TaskItem()
        {
            
        }
        public TaskItem (string description, string quantity, bool isCompleted,int storeId)
        {
            Description = description;
            Quantity = quantity;
            IsCompleted = isCompleted;
            StoreId = storeId;
        }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
