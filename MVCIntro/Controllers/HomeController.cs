using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCIntro.Models.BaseModels;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Home home = new Home();
            home.HomeID = 1;
            home.Text = "Welcome to my first MVC application!";
            home.Image = "Cookie.png";

            return View(home);
        }

        public ActionResult About()
        {
            About about = new About();
            about.AboutID = 1;
            about.Text = "I'm a guy, that makes MVC Applications";
            about.Image = "N/A";

            return View(about);
        }

        public ActionResult Gallery()
        {
            List<Gallery> galleries = new List<Gallery>();
            galleries.Add(new Gallery() { GalleryID = 1, Title = "Biler" });
            galleries.Add(new Gallery() { GalleryID = 2, Title = "Fugle" });
            galleries.Add(new Gallery() { GalleryID = 3, Title = "Fisk" });

            return View(galleries);
        }

        public ActionResult ShowGallery(int id)
        {
            List<GalleryImage> galleryImages = new List<GalleryImage>();
            galleryImages.Add(new GalleryImage() { GalleryImageID = 1, Title = "Fisk1", GalleryID = 3, Image = "fisk1.jpg" });
            galleryImages.Add(new GalleryImage() { GalleryImageID = 2, Title = "Fisk2", GalleryID = 3, Image = "fisk2.jpg" });
            galleryImages.Add(new GalleryImage() { GalleryImageID = 3, Title = "Fisk3", GalleryID = 3, Image = "fisk3.jpg" });

            galleryImages.Add(new GalleryImage() { GalleryImageID = 3, Title = "Bil1", GalleryID = 1, Image = "bil1.jpg" });


            return View(galleryImages.Where(x => x.GalleryID == id).ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}