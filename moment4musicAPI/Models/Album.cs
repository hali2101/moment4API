using System;
namespace moment4musicAPI.Models
{
    //skapar klass för tabellen track
    public class Album
    {

        //properties
        public int AlbumId { get; set; }

        public string? AlbumName { get; set; }

        public ICollection<Track>? Track { get; set; }

    }
}

