using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class KhasTarin
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }

        public KhasTarin(long id, string title, string description, string image, string client)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}
