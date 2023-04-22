﻿using GeekShopping.ProductAPI.Data.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 2,
                Name = "Camiseta Feminina tamanha M",
                Price = new decimal(69.90),
                Description = "As Camisetas/Blusas Femininas mais legais de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 3,
                Name = "Capacete Darth Vader Star Wars Black Series",
                Price = new decimal(999.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true",
                CategoryName = "Action Figure"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 4,
                Name = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                Price = new decimal(189.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true",
                CategoryName = "Action Figure"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 5,
                Name = "Camiseta Gamer",
                Price = new decimal(69.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 6,
                Name = "Camiseta SpaceX",
                Price = new decimal(49.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 7,
                Name = "Camiseta Feminina Coffee Benefits",
                Price = new decimal(69.9),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 8,
                Name = "Moletom Com Capuz Cobra Kai",
                Price = new decimal(159.9),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                CategoryName = "Sweatshirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 9,
                Name = "Livro Star Talk – Neil DeGrasse Tyson",
                Price = new decimal(49.9),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true",
                CategoryName = "Book"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 10,
                Name = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                Price = new decimal(359.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                CategoryName = "Action Figure"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 11,
                Name = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                Price = new decimal(59.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 12,
                Name = "Camiseta GNU Linux Programador Masculina",
                Price = new decimal(59.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                CategoryName = "T-shirt"
            });

            modelBuilder.Entity<Product>().HasData(new ProductVO
            {
                Id = 13,
                Name = "Camiseta Goku Fases",
                Price = new decimal(59.99),
                Description = "Os melhores produtos de Super Herois, Games e Series voce encontra aqui na Geek Shopping",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "T-shirt"
            });
        }
    }
}
