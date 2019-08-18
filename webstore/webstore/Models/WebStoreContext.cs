using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webstore.Models
{
    public class WebStoreContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }

        public WebStoreContext(DbContextOptions<WebStoreContext> options)
                        : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cat1 = new Category { Id = 1, Name = "Мужчины" };
            var cat2 = new Category { Id = 2, Name = "Женщины" };
            modelBuilder.Entity<Category>().HasData(cat1, cat2);

            var scat1 = new Subcategory { Id = 1, Name = "Верхняя одежда", CategoryId = cat1.Id };
            var scat2 = new Subcategory { Id = 2, Name = "Верхняя одежда", CategoryId = cat2.Id };
            var scat3 = new Subcategory { Id = 3, Name = "Обувь", CategoryId = cat1.Id };
            modelBuilder.Entity<Subcategory>().HasData(scat1, scat2, scat3);

            var roleOwner = new Role { Id = 1, Name = "owner" };
            var roleAdmin = new Role { Id = 2, Name = "admin" };
            var roleManager = new Role { Id = 3, Name = "manager" };
            var roleUser = new Role { Id = 4, Name = "user" };
            modelBuilder.Entity<Role>().HasData(roleOwner, roleAdmin, roleManager, roleUser);

            var owner = new User { Id = 1, Login = "owner", Password = "owner", RoleId = roleOwner.Id };
            modelBuilder.Entity<User>().HasData(owner);

            var item1 = new Item { Id = 1, Name = "Куртка мужская", Price = 6000, Description = "lorem", SubcategoryId = scat1.Id };
            var item2 = new Item { Id = 2, Name = "Парка", Price = 8000, Description = "lorem", SubcategoryId = scat1.Id };
            var item3 = new Item { Id = 3, Name = "Кеды мужские", Price = 2900, Description = "lorem", SubcategoryId = scat3.Id };
            modelBuilder.Entity<Item>().HasData(item1, item2, item3);
        }
    }
}
