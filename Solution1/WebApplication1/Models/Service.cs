using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Service(int id,string name)
        {
            Name = name;
            Id = id;
        }
    }
}
