using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moment4musicAPI.Models
{

        //skapar klass för tabellen track
        public class Track
        {

            //properties
            public int TrackId { get; set; }

            [Required]
            public string? Title { get; set; }

            [Required]
            public string? Artist { get; set; }

            [Required]
            public int? TrackLength { get; set; }

            [ForeignKey("Album")]
            public int? AlbumId { get; set; }
            public Album? Album { get; set; }

            [ForeignKey("Category")]
            public int? CategoryId { get; set; }
            public Category? Category { get; set; }

        }

}

