﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class WantToPlayContext : DbContext
    {
        public WantToPlayContext(DbContextOptions<WantToPlayContext> options) : base(options) { }

        public DbSet<GameInfoModel> GameInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameInfoModel>().HasData(
                new GameInfoModel { GameID = 1, Name = "Asteroids", ReleaseDate = "11/1979", Platform = "Arcade" }
                );
        }
    }
}
