using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                context.AddRange(
                        new Product { Name = "Apple IPhone 8", Category = "Smartphones", Condition = "preowned", Description = "iPhone 8 bought January 2018 in perfect condition.", Price = 1900, Seller = "shom123", ImageUrl = "/images/smartphone.jpg", ThumbnailUrl = "/images/smartphone.jpg", IsFeatured = false },
                        new Product { Name = "Sony Speakers", Category = "Audio Devices", Condition = "new", Description = "5.1 Surround Home Theater Speakers.", Price = 4000, Seller = "SonyPoland", ImageUrl = "/images/speakers.jpg", ThumbnailUrl = "/images/speakers.jpg", IsFeatured = false },
                        new Product { Name = "Nike Raygun ", Category = "Athletic Shoes", Condition = "preowned", Description = "Used Nike shoes, good condition.", Price = 400, Seller = "gransenio68", ImageUrl = "/images/shoes.jpg", ThumbnailUrl = "/images/shoes.jpg", IsFeatured = false },
                        new Product { Name = "Samsung Q70R 4K TV", Category = "Televisions", Condition = "new", Description = "TV with amazing picture quality and premium sound system.", Price = 3500, Seller = "whover22", ImageUrl = "/images/tv.jpg", ThumbnailUrl = "/images/tv.jpg", IsFeatured = true },
                        new Product { Name = "Dark Souls III PS4", Category = "Playstation 4 Games", Condition = "preowned", Description = "Selling because it makes me boil with rage.", Price = 120, Seller = "aszalke", ImageUrl = "/images/game.jpg", ThumbnailUrl = "/images/game.jpg", IsFeatured = true },
                        new Product { Name = "LEGO Millenium Falcon", Category = "Toys", Condition = "new", Description = "LEGO Star Wars Millenium Falcon set for children.", Price = 150, Seller = "toysboys", ImageUrl = "/images/toy.jpg", ThumbnailUrl = "/images/toy.jpg", IsFeatured = false }
                    );
            }
            context.SaveChanges();
        }
    }
}
