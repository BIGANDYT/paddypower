using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    public class NavList : IRenderingModel
    {
        public List<Item> Data { get; set; }

        public void Initialize(Rendering rendering) {
            Sitecore.Data.Database db = Sitecore.Data.Database.GetDatabase("master");
            Data = db.SelectItems("fast:/sitecore/Content/Sport//*[@@templatename='Bet']").OrderBy(x => x.Name).ToList();
        }
    }
}