using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace moment4musicAPI.Models
{

        //skapar klass för tabellen track
        public class Track
        {

            //properties
            public int TrackId { get; set; }

            public string? Title { get; set; }

            public string? Artist { get; set; }

            public int? TrackLength { get; set; }

            [ForeignKey("Album")]
            public int? AlbumId { get; set; }
            public Album? Album { get; set; }

            [ForeignKey("Category")]
            public int? CategoryId { get; set; }
            public Category? Category { get; set; }

        }

}

