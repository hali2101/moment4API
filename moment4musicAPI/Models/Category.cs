using System;
using System.ComponentModel.DataAnnotations;

namespace moment4musicAPI.Models
{

    //skapar klass för tabellen track
    public class Category
    {

        //properties
        public int CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }

    }
}

