using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class TableData : IRenderingModel
    {
        public List<string> Data { get; set; }

        public void Initialize(Rendering rendering)
        {
            Data = new List<string> { "Hi", "Andy" };
        }
    }
}