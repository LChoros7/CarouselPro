using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CarouselPro.Models;
using CarouselPro.Models.DAL;

namespace CarouselProject.Api.Controlllers
{
    public class SlidesController : ApiController
    {
        private CarouselProContext db = new CarouselProContext();

        // GET: api/Slides
        public IQueryable<Slide> GetSlides()
        {
            return db.Slides;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}