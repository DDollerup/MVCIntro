using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCIntro.Models.BaseModels
{
    public class GalleryImage
    {
        public int GalleryImageID { get; set; }
        public string Title { get; set; }
        public int GalleryID { get; set; }
        public string Image { get; set; }
    }
}