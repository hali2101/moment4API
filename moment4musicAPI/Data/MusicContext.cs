using System;
using Microsoft.EntityFrameworkCore;
using moment4musicAPI.Models;

namespace moment4musicAPI.Data
{
    //skapar klassen
    public class MusicContext : DbContext
    {

        //skapar constructor
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        //Skapar en dbSet
        public DbSet<Track>? Tracks { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Album>? Albums { get; set; }
    }
}

