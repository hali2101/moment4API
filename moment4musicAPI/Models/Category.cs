using System;
namespace moment4musicAPI.Models
{

    //skapar klass för tabellen track
    public class Category
    {

        //properties
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public ICollection<Track>? Track { get; set; }

    }
}

