using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using CarouselPro.Models.DAL;

namespace CarouselPro.Models.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DAL.CarouselProContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.CarouselProContext context)
        {
            base.Seed(context);
            SeedSlides(context);
        }
        private void SeedSlides(CarouselProContext context)
        {
            var slides = new List<Slide>
            {
                new Slide { Path = "http://www.clipartkid.com/images/589/man-talking-clip-art-2pegJQ-clipart.jpg", CaptionText = "CREATIVE DESIGN", AltText = "man talking picture digital design", CreatedAt = DateTime.Now },
                new Slide { Path = "http://worldartsme.com/images/daunting-clipart-1.jpg", CaptionText = "HIGH QUALITY", AltText = "Man Scared image creative agency", CreatedAt = DateTime.Now },
                new Slide { Path = "http://res.freestockphotos.biz/pictures/7/7005-illustration-of-a-man-talking-on-a-telephone-pv.png", CaptionText = "GREAT COMMUNICATION", AltText = "Man On Phone image communication", CreatedAt = DateTime.Now }
            };
            slides.ForEach(s => context.Slides.Add(s));
            context.SaveChanges();
        }
    }
}
