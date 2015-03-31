using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class BannerModel : IRenderingModel
    {
        public List<string> AndysList { get; set; }

        public void Initialize(Rendering rendering)
        {
            AndysList = new List<string> { "Hi", "Andy" };
        }
    }
}