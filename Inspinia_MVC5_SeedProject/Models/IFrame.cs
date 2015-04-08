using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inspinia_MVC5_SeedProject.Service;
using Inspinia_MVC5_SeedProject.Service.Impl;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Sites;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class IFrame : IRenderingModel
    {
        public string Source;

        public void Initialize(Rendering rendering)
        {
            if (!String.IsNullOrEmpty(rendering.DataSource))
            {
                Item i = Sitecore.Context.Database.GetItem(rendering.DataSource);
                Source = i.Fields["IFrame Link"].Value;
            }
        }
    }
}