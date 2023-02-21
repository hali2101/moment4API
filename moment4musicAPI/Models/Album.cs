using System;
using System.ComponentModel.DataAnnotations;

namespace moment4musicAPI.Models
{
    //skapar klass för tabellen track
    public class Album
    {

        //properties
        public int AlbumId { get; set; }

        [Required]
        public string? AlbumName { get; set; }
    }
}

