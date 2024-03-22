using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Domain.Common;

namespace TestApi.Domain.Entities
{
    public class Store:EntityBase
    {
        public Store()
        {
            
        }
        public Store(string name, int priorty)
        {
            Name = name;
            Priorty = priorty;
        }

        public string Name { get; set; }
        public int Priorty { get; set; }
        public ICollection<TaskItem> Items { get; set; }
    }
}
