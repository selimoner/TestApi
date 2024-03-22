using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Domain.Common;

namespace TestApi.Domain.Entities
{
    public class Detail:EntityBase
    {
        public Detail()
        {
            
        }
        public Detail(string title, string description, int categoryId)
        {
            Description = description;
            CategoryId = categoryId;
            Title = title;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
