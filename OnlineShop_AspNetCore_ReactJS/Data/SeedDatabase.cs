﻿using Microsoft.EntityFrameworkCore;
using OnlineShop_AspNetCore_ReactJS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop_AspNetCore_ReactJS.Data
{
    public class SeedDatabase
    {
        public static Tuple<Banner[], Category[], Pie[]> Initialize(OnlineShopContext context)
        {
            context.Database.Migrate();

            Banner[] banners = null;
            if (!context.Banner.Any())
            {
                banners = new Banner[] {
                    new Banner { Name = "Carousel1", Description = "We sell the best pies in the town!", ImageUrl = "/images/carousel1.jpg" },
                    new Banner { Name = "Carousel2", Description = "We sell the best pies in the town!", ImageUrl = "/images/carousel2.jpg" },
                    new Banner { Name = "Carousel3", Description = "We sell the best pies in the town!", ImageUrl = "/images/carousel3.jpg" }
                };
                context.Banner.AddRange(banners);
            }

            Category[] categories = null;
            Category categoryFruitPies = new Category { Name = "Fruit pies", Description = "Fruit pies" };
            Category categoryCheeseCakes = new Category { Name = "Cheese cakes", Description = "Cheese cakes" };
            Category categorySeasonalPies = new Category { Name = "Seasonal pies", Description = "Seasonal pies" };
            if (!context.Category.Any())
            {
                categories = new Category[] { categoryFruitPies, categoryCheeseCakes, categorySeasonalPies };
                context.Category.AddRange(categories);
            }

            Pie[] pies = null;
            if (!context.Pie.Any())
            {
                string longDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.";

                pies = new Pie[] {
                    new Pie
                    {
                        Name = "Apple Pie",
                        Price = 12.95M,
                        ShortDescription = "Our famous apple pies!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/applepie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/applepiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = true,
                        Category = categoryFruitPies
                    },
                    new Pie
                    {
                        Name = "Blueberry Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "You'll love it!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/blueberrycheesecake.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/blueberrycheesecakesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        Category = categoryCheeseCakes
                    },
                    new Pie
                    {
                        Name = "Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "Plain cheese cake. Plain pleasure.",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/cheesecake.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/cheesecakesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        Category = categoryCheeseCakes
                    },
                    new Pie
                    {
                        Name = "Cherry Pie",
                        Price = 15.95M,
                        ShortDescription = "A summer classic!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/cherrypie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/cherrypiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        Category = categoryFruitPies
                    },
                    new Pie
                    {
                        Name = "Christmas Apple Pie",
                        Price = 13.95M,
                        ShortDescription = "Happy holidays with this pie!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/christmasapplepie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/christmasapplepiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        Category = categorySeasonalPies
                    },
                    new Pie
                    {
                        Name = "Cranberry Pie",
                        Price = 17.95M,
                        ShortDescription = "A Christmas favorite",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/cranberrypie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/cranberrypiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        Category = categorySeasonalPies
                    },
                    new Pie
                    {
                        Name = "Peach Pie",
                        Price = 15.95M,
                        ShortDescription = "Sweet as peach",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/peachpie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/peachpiesmall.jpg",
                        InStock = false,
                        IsPieOfTheWeek = false,
                        Category = categoryFruitPies
                    },
                    new Pie
                    {
                        Name = "Pumpkin Pie",
                        Price = 12.95M,
                        ShortDescription = "Our Halloween favorite",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/pumpkinpie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/pumpkinpiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = true,
                        Category = categorySeasonalPies
                    },
                    new Pie
                    {
                        Name = "Rhubarb Pie",
                        Price = 15.95M,
                        ShortDescription = "My God, so sweet!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/rhubarbpie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/rhubarbpiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = true,
                        Category = categoryFruitPies
                    },
                    new Pie
                    {
                        Name = "Strawberry Pie",
                        Price = 15.95M,
                        ShortDescription = "Our delicious strawberry pie!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/strawberrypie.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/strawberrypiesmall.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        Category = categoryFruitPies
                    },
                    new Pie
                    {
                        Name = "Strawberry Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "You'll love it!",
                        LongDescription = longDescription,
                        ImageUrl = "/images/pies/strawberrycheesecake.jpg",
                        ThumbnailImageUrl = "/images/pies/thumbnails/strawberrycheesecakesmall.jpg",
                        InStock = false,
                        IsPieOfTheWeek = false,
                        Category = categoryCheeseCakes
                    }
                };
                context.Pie.AddRange(pies);
            }
            context.SaveChanges();

            return new Tuple<Banner[], Category[], Pie[]>(banners, categories, pies);
        }
    }
}